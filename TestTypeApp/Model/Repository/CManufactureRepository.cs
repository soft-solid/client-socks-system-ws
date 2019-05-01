using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TestTypeApp.ManufactureService;
using TestTypeApp.Tools.CustomBindingList;

namespace TestTypeApp.Model.Repository
{
    class CManufactureRepository : IBaseRepositoryModel<CManufacture>
    {
        readonly ManufactureServiceClient _service;
        readonly List<CManufacture> _toSave;
        readonly List<int> _toDelete;
        readonly Client.Converter<manufacture, CManufacture> _converter;
        BindingListWithDeleteDetecting<CManufacture> _manufactures;

        public CManufactureRepository(ManufactureServiceClient service)
        {
            _service = service;
            _manufactures = new BindingListWithDeleteDetecting<CManufacture>();
            _toSave = new List<CManufacture>();
            _toDelete = new List<int>();
            _converter = new Client.Converter<manufacture, CManufacture>();
            _manufactures.ListChanged += Manufactures_ListChanged;
            _manufactures.RemovingItem += Manufactures_ListRemove;
        }

        private void Manufactures_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((e.ListChangedType == ListChangedType.ItemChanged &&
                  _toSave.Exists(x => x == _manufactures[e.NewIndex])))
            {
                _toSave[_toSave.IndexOf(_manufactures[e.NewIndex])] = _manufactures[e.NewIndex];
            }
            else if ((e.ListChangedType == ListChangedType.ItemAdded ||
                     !_toSave.Exists(x => x == _manufactures[e.NewIndex])) &&
                     e.ListChangedType != ListChangedType.ItemDeleted)
            {
                _toSave.Add(_manufactures[e.NewIndex]);
            }
        }

        private void Manufactures_ListRemove(object sender, RemoveItemEventArgs e)
        {
            _toDelete.Add(((CManufacture)e.RemovedItem).Id);
        }

        public void Reload()
        {
            _manufactures.ListChanged -= Manufactures_ListChanged;
            _toDelete.Clear();
            _toSave.Clear();
            _manufactures.Clear();
            _converter.toClientType(_service.ReadAll())
                      .ForEach(n => _manufactures.Add(n));
            _manufactures.ListChanged += Manufactures_ListChanged;
        }

        public void Save()
        {
            if (_toSave.Count > 0)
            {
                SaveResponseEntry[] responce = _service.Save(_converter.toDto(_toSave));
                updateEntities(responce);
            }

            if (_toDelete.Count > 0)
            {
                _service.Deactivate(_toDelete.ToArray());
            }
        }

        private void updateEntities(SaveResponseEntry[] dictionary)
        {
            foreach (var item in dictionary)
            {
                _manufactures.Single(x => x.Name == item.key).Id = item.value;
            }
        }

        public BindingListWithDeleteDetecting<CManufacture> ItemList
        {
            get
            {
                return _manufactures;
            }
            set
            {
                _manufactures = value;
            }
        }

        public CManufacture CreateNew()
        {
            return _manufactures.AddNew();
        }
    }
}

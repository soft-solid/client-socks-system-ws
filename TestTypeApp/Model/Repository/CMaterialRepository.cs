using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TestTypeApp.MaterialService;
using TestTypeApp.Tools.CustomBindingList;

namespace TestTypeApp.Model.Repository
{
    class CMaterialRepository : IBaseRepositoryModel<CMaterial>
    {
        readonly MaterialServiceClient _service;
        readonly List<CMaterial> _toSave;
        readonly List<int> _toDelete;
        readonly Client.Converter<material, CMaterial> _converter;
        BindingListWithDeleteDetecting<CMaterial> _materials;

        public CMaterialRepository(MaterialServiceClient service)
        {
            _service = service;
            _materials = new BindingListWithDeleteDetecting<CMaterial>();
            _toSave = new List<CMaterial>();
            _toDelete = new List<int>();
            _converter = new Client.Converter<material, CMaterial>();
            _materials.ListChanged += Materials_ListChanged;
            _materials.RemovingItem += Materials_ListRemove;
        }

        private void Materials_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((e.ListChangedType == ListChangedType.ItemChanged &&
                  _toSave.Exists(x => x == _materials[e.NewIndex])))
            {
                _toSave[_toSave.IndexOf(_materials[e.NewIndex])] = _materials[e.NewIndex];
            }
            else if ((e.ListChangedType == ListChangedType.ItemAdded ||
                     !_toSave.Exists(x => x == _materials[e.NewIndex])) &&
                     e.ListChangedType != ListChangedType.ItemDeleted)
            {
                _toSave.Add(_materials[e.NewIndex]);
            }
        }

        private void Materials_ListRemove(object sender, RemoveItemEventArgs e)
        {
            _toDelete.Add(((CMaterial)e.RemovedItem).Id);
        }

        public void Reload()
        {
            _materials.ListChanged -= Materials_ListChanged;
            _toDelete.Clear();
            _toSave.Clear();
            _materials.Clear();
            _converter.toClientType(_service.ReadAll(true))
                      .ForEach(n => _materials.Add(n));
            _materials.ListChanged += Materials_ListChanged;
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
                _materials.Single(x => x.Name == item.key).Id = item.value;
            }
        }

        public BindingListWithDeleteDetecting<CMaterial> ItemList
        {
            get
            {
                return _materials;
            }
            set
            {
                _materials = value;
            }
        }

        public CMaterial CreateNew()
        {
            return _materials.AddNew();
        }
    }
}

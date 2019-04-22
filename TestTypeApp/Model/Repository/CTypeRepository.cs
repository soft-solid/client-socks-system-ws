using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TestTypeApp.Tools.CustomBindingList;
using TestTypeApp.TypeService;

namespace TestTypeApp.Model.Repository
{
    class CTypeRepository : IBaseRepositoryModel<CType>
    {
        readonly TypeServiceClient _service;
        readonly List<CType> _toSave;
        readonly List<int> _toDelete;
        readonly Client.Converter<socksType, CType> _converter;
        BindingListWithDeleteDetecting<CType> _types;

        public CTypeRepository(TypeServiceClient service)
        {
            _service = service;
            _types = new BindingListWithDeleteDetecting<CType>();
            _toSave = new List<CType>();
            _toDelete = new List<int>();
            _converter = new Client.Converter<socksType, CType>();
            _types.ListChanged += types_ListChanged;
            _types.RemovingItem += types_ListRemove;
        }

        private void types_ListChanged(object sender, ListChangedEventArgs e)
        {
            if ((e.ListChangedType == ListChangedType.ItemChanged &&
                  _toSave.Exists(x => x == _types[e.NewIndex])))
            {
                _toSave[_toSave.IndexOf(_types[e.NewIndex])] = _types[e.NewIndex];
            }
            else if (e.ListChangedType == ListChangedType.ItemAdded ||
                     !_toSave.Exists(x => x == _types[e.NewIndex]))
            {
                _toSave.Add(_types[e.NewIndex]);
            }
        }

        private void types_ListRemove(object sender, RemoveItemEventArgs e)
        {
            _toDelete.Add(((CType) e.RemovedItem).Id);
        }

        public void Reload()
        {
            _types.ListChanged -= types_ListChanged;
            _toDelete.Clear();
            _toSave.Clear();
            _types.Clear();
            _converter.toClientType(_service.ReadAll())
                      .ForEach(n => _types.Add(n));
            _types.ListChanged += types_ListChanged;
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

        private void updateEntities(/*Dictionary<string, int>*/SaveResponseEntry[] dictionary)
        {
            foreach (var item in dictionary)
            {
                _types.Single(x => x.Name == item.key).Id = item.value;
            }
        }

        public BindingListWithDeleteDetecting<CType> ItemList
        {
            get
            {
                return _types;
            }
            set
            {
                _types = value;
            }
        }

        public CType CreateNew()
        {
            return _types.AddNew();
        }
    }
}

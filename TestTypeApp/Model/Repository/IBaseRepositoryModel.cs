using TestTypeApp.Tools.CustomBindingList;

namespace TestTypeApp.Model.Repository
{
    interface IBaseRepositoryModel<TClietType>
    {
        void Save();
        void Reload();
        TClietType CreateNew();
        BindingListWithDeleteDetecting<TClietType> ItemList { get; set; }
    }
}

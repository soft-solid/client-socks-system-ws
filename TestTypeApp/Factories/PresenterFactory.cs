using System.Windows.Forms;
using TestTypeApp.Factories.Interfaces;
using TestTypeApp.Model.Repository;
using TestTypeApp.Presenter;
using TestTypeApp.TypeService;

using TestTypeApp.View.Entries;
using TestTypeApp.ManufactureService;
using TestTypeApp.MaterialService;

namespace TestTypeApp.Factories
{
    class PresenterFactory : IPresenterFactory
    {
        private static PresenterFactory _instance = null;
        private static readonly object padlock = new object();

        public static IPresenterFactory Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance != null) return _instance;
                    _instance = new PresenterFactory();

                    return _instance;
                }
            }
        }

        public IPresenter GetTypePresenter(Form MDIParent)
        {
            return new TypePresenter(new CTypeRepository(new TypeServiceClient()), new TypeEntry() { MdiParent = MDIParent });
        }

        public IPresenter GetManufacturePresenter(Form MDIParent)
        {
            return new ManufacturePresenter(new CManufactureRepository(new ManufactureServiceClient()), new ManufactureEntry() { MdiParent = MDIParent });
        }

        public IPresenter GetMaterialPresenter(Form MDIParent)
        {
            return new MaterialPresenter(new CMaterialRepository(new MaterialServiceClient()), new MaterialEntry() { MdiParent = MDIParent });
        }
    }
}

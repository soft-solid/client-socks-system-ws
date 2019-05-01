using System.Windows.Forms;
using TestTypeApp.Presenter;

namespace TestTypeApp.Factories.Interfaces
{
    public interface IPresenterFactory
    {
        IPresenter GetTypePresenter(Form MDIParent);

        IPresenter GetManufacturePresenter(Form MDIParent);

        IPresenter GetMaterialPresenter(Form MDIParent);
    }
}

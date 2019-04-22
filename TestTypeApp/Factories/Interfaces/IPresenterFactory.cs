using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Presenter;

namespace TestTypeApp.Factories.Interfaces
{
    public interface IPresenterFactory
    {
        IPresenter GetTypePresenter(Form MDIParent);
    }
}

using System.Windows.Forms;
using TestTypeApp.Factories.Interfaces;
using TestTypeApp.Presenter;

namespace TestTypeApp.View.Entries
{
    public partial class MainForm : Form
    {
        readonly IPresenterFactory _presenterFactory;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(IPresenterFactory presenterFactory)
            : this()
        {
            _presenterFactory = presenterFactory;
        }

        private void TypebarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            IPresenter typePresenter = _presenterFactory.GetTypePresenter(this);
            TypebarButtonItem.Enabled = false;
            typePresenter.FormClosing += (o, i) => TypebarButtonItem.Enabled = true;
        }

        private void ManufacturesbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IPresenter manufacturePresenter = _presenterFactory.GetManufacturePresenter(this);
            ManufacturesbarButtonItem.Enabled = false;
            manufacturePresenter.FormClosing += (o, i) => ManufacturesbarButtonItem.Enabled = true;
        }

        private void MaterialsbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            IPresenter materialPresenter = _presenterFactory.GetMaterialPresenter(this);
            MaterialsbarButtonItem.Enabled = false;
            materialPresenter.FormClosing += (o, i) => MaterialsbarButtonItem.Enabled = true;
        }
    }
}

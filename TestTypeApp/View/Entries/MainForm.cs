using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Factories.Interfaces;
using TestTypeApp.Model.Repository;
using TestTypeApp.Presenter;

namespace TestTypeApp.View.Entries
{
    public partial class MainForm : Form
    {
        private readonly IPresenterFactory _presenterFactory;

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
        }
    }
}

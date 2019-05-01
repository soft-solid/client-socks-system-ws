using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View.Entries
{
    public partial class ManufactureEntry : Form, IItemView<CManufacture>
    {
        public ManufactureEntry()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> RefreshView;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> AddNew;

        public IList<CManufacture> ItemList
        {
            set { ManufactureGrid.DataSource = value; }
        }

        public CManufacture CurrentItem
        {
            get { return manufactureControl.DataSource; }
            set { manufactureControl.DataSource = value; }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            if (AddNew != null)
            {
                AddNew(this, EventArgs.Empty);
            }
            else
            {
                //Log this with specific logger!!
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (Save != null)
            {
                Save(this, EventArgs.Empty);
            }
            else
            {
                //Log this with specific logger!!
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ManufactureGridView.DeleteSelectedRows();
            manufactureControl.DataSource = (CManufacture)ManufactureGridView.GetRow(ManufactureGridView.FocusedRowHandle);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            if (RefreshView != null)
            {
                RefreshView(this, EventArgs.Empty);
            }
            else
            {
                //Log this with specific logger!!
            }
        }

        private void ManufactureGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            manufactureControl.DataSource = (CManufacture)ManufactureGridView.GetRow(e.FocusedRowHandle);
        }
    }
}

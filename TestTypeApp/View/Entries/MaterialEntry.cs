using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View.Entries
{
    public partial class MaterialEntry : Form, IItemView<CMaterial>
    {
        public MaterialEntry()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> RefreshView;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> AddNew;

        public IList<CMaterial> ItemList
        {
            set { MaterialGrid.DataSource = value; }
        }

        public CMaterial CurrentItem
        {
            get { return materialControl.DataSource; }
            set { materialControl.DataSource = value; }
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
            MaterialGridView.DeleteSelectedRows();
            materialControl.DataSource = (CMaterial)MaterialGridView.GetRow(MaterialGridView.FocusedRowHandle);

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

        private void MaterialGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            materialControl.DataSource = (CMaterial)MaterialGridView.GetRow(e.FocusedRowHandle);
        }
    }
}

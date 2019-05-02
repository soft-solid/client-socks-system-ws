using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View.Entries
{
    public partial class TypeEntry : Form, IItemView<CType>
    {
        public TypeEntry()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> RefreshView;
        public event EventHandler<EventArgs> Save;
        public event EventHandler<EventArgs> AddNew;

        public IList<CType> ItemList
        {
            set { Typegrid.DataSource = value; }
        }

        public CType CurrentItem
        {
            get { return typeControl.DataSource; }
            set { typeControl.DataSource = value; }
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            TypegridView.DeleteSelectedRows();
            typeControl.DataSource = (CType)TypegridView.GetRow(TypegridView.FocusedRowHandle);
        }

        private void TypegridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            typeControl.DataSource = (CType)TypegridView.GetRow(e.FocusedRowHandle);
        }

        
    }
}

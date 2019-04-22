using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTypeApp.Client;
using TestTypeApp.Model;
using TestTypeApp.View;

namespace TestTypeApp
{
    public partial class TypeSetupControl : UserControl, IItemView<CType>
    {
        public TypeSetupControl()
        {
            InitializeComponent();
        }

        public event EventHandler<EventArgs> RefreshView;
        public event EventHandler<EventArgs> Save;
        CType currentItem;

        public IList<CType> ItemList
        {
           set
            {
                    typesListBox.DataSource = value;
                    typesListBox.DisplayMember = "Name";
                    typesListBox.ValueMember = "Id";
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Save(this, e);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshView(this, e);
        }

        private void typesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            typeControl1.DataSource = (CType)typesListBox.SelectedItem;
        }

        public CType CurrentItem
        {
            get { return (CType)typesListBox.SelectedItem; }
            set { typesListBox.SelectedItem = value; }
        }

        public Form MdiParent
        {
            get
            {
                return MdiParent;
            }
            set
            {
                MdiParent = value;
            }
        }


        public event EventHandler<EventArgs> AddNew;
    }
}

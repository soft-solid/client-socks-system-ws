using System;
using System.ComponentModel;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View.CustomControls
{
    public partial class ManufactureControl : UserControl
    {
        public ManufactureControl()
        {
            InitializeComponent();
        }

        private CManufacture _manufacture;

        private void manufactureNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            _manufacture.Name = manufactureNameEdit.Text;
        }

        private void manufacture_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
                manufactureNameEdit.Text = _manufacture.Name;
            else
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
        }

        public CManufacture DataSource
        {
            set
            {
                if (value == null || _manufacture == value)
                    return;

                if (_manufacture != null)
                    _manufacture.PropertyChanged -= manufacture_PropertyChanged;

                manufactureNameEdit.EditValueChanged -= manufactureNameEdit_EditValueChanged;
                _manufacture = value;
                manufactureNameEdit.Text = _manufacture.Name;
                manufactureNameEdit.EditValueChanged += manufactureNameEdit_EditValueChanged;
                _manufacture.PropertyChanged += manufacture_PropertyChanged;
            }
            get { return _manufacture; }
        }

    }
}

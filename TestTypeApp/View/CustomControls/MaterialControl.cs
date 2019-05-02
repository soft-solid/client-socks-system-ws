using System;
using System.ComponentModel;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View.CustomControls
{
    public partial class MaterialControl : UserControl
    {
        public MaterialControl()
        {
            InitializeComponent();
        }

        CMaterial _material;
        
        private void materailNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            _material.Name = materailNameEdit.Text;
        }

        private void material_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
                materailNameEdit.Text = _material.Name;
            else
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
        }

        public CMaterial DataSource
        {
            set
            {
                if (value == null || _material == value)
                    return;

                if (_material != null)
                    _material.PropertyChanged -= material_PropertyChanged;

                materailNameEdit.EditValueChanged -= materailNameEdit_EditValueChanged;
                _material = value;
                materailNameEdit.Text = _material.Name;
                materailNameEdit.EditValueChanged += materailNameEdit_EditValueChanged;
                _material.PropertyChanged += material_PropertyChanged;
            }
            get { return _material; }
        }
    }
}

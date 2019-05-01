using System;
using System.ComponentModel;
using System.Windows.Forms;
using TestTypeApp.Model;

namespace TestTypeApp.View
{
    public partial class TypeControl : UserControl
    {
        public TypeControl()
        {
            InitializeComponent();
        }

        CType _type;

        public CType DataSource
        {
            set
            {
                if (value == null || _type == value) 
                    return;

                if (_type != null) 
                    _type.PropertyChanged -= type_PropertyChanged;

                typeNameEdit.EditValueChanged -= typeNameEdit_EditValueChanged;
                _type = value;
                typeNameEdit.Text = _type.Name;
                typeNameEdit.EditValueChanged += typeNameEdit_EditValueChanged;
                _type.PropertyChanged += type_PropertyChanged;
            }
            get { return _type; }
        }

        private void type_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
                typeNameEdit.Text = _type.Name;
            else
                throw new NotImplementedException("Unsupported property: " + e.PropertyName);
        }

        private void typeNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            _type.Name = typeNameEdit.Text;
        }
    }
}

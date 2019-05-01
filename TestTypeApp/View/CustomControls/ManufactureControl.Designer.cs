using System.Windows.Forms;
namespace TestTypeApp.View.CustomControls
{
    partial class ManufactureControl : UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.manufactureNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.manufactureNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // manufactureNameEdit
            // 
            this.manufactureNameEdit.Location = new System.Drawing.Point(15, 26);
            this.manufactureNameEdit.Name = "manufactureNameEdit";
            this.manufactureNameEdit.Size = new System.Drawing.Size(203, 20);
            this.manufactureNameEdit.TabIndex = 0;
            this.manufactureNameEdit.EditValueChanged += new System.EventHandler(this.manufactureNameEdit_EditValueChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(15, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(90, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Manufacture name";
            // 
            // ManufactureControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.manufactureNameEdit);
            this.MaximumSize = new System.Drawing.Size(236, 62);
            this.Name = "ManufactureControl";
            this.Size = new System.Drawing.Size(236, 62);
            ((System.ComponentModel.ISupportInitialize)(this.manufactureNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl NameLabel;
        private DevExpress.XtraEditors.TextEdit manufactureNameEdit;
    }
}

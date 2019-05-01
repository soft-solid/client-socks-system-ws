namespace TestTypeApp.View.CustomControls
{
    partial class MaterialControl
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
            this.NameLabel = new DevExpress.XtraEditors.LabelControl();
            this.materailNameEdit = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.materailNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(15, 7);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(67, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Material name";
            // 
            // materailNameEdit
            // 
            this.materailNameEdit.Location = new System.Drawing.Point(15, 26);
            this.materailNameEdit.Name = "materailNameEdit";
            this.materailNameEdit.Size = new System.Drawing.Size(203, 20);
            this.materailNameEdit.TabIndex = 1;
            this.materailNameEdit.EditValueChanged += new System.EventHandler(this.materailNameEdit_EditValueChanged);
            // 
            // MaterialControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materailNameEdit);
            this.Controls.Add(this.NameLabel);
            this.MaximumSize = new System.Drawing.Size(236, 62);
            this.Name = "MaterialControl";
            this.Size = new System.Drawing.Size(236, 62);
            ((System.ComponentModel.ISupportInitialize)(this.materailNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl NameLabel;
        private DevExpress.XtraEditors.TextEdit materailNameEdit;
        private CustomControls.MaterialControl materialControl;
    }
}

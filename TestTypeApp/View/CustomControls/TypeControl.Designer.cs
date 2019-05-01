namespace TestTypeApp.View
{
    partial class TypeControl
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
            this.typeNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.NameLabal = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.typeNameEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // typeNameEdit
            // 
            this.typeNameEdit.Location = new System.Drawing.Point(15, 26);
            this.typeNameEdit.Name = "typeNameEdit";
            this.typeNameEdit.Size = new System.Drawing.Size(203, 20);
            this.typeNameEdit.TabIndex = 1;
            this.typeNameEdit.EditValueChanged += new System.EventHandler(this.typeNameEdit_EditValueChanged);
            // 
            // NameLabal
            // 
            this.NameLabal.Location = new System.Drawing.Point(15, 7);
            this.NameLabal.Name = "NameLabal";
            this.NameLabal.Size = new System.Drawing.Size(53, 13);
            this.NameLabal.TabIndex = 2;
            this.NameLabal.Text = "Type name";
            // 
            // TypeControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NameLabal);
            this.Controls.Add(this.typeNameEdit);
            this.MaximumSize = new System.Drawing.Size(236, 62);
            this.Name = "TypeControl";
            this.Size = new System.Drawing.Size(236, 62);
            ((System.ComponentModel.ISupportInitialize)(this.typeNameEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit typeNameEdit;
        private DevExpress.XtraEditors.LabelControl NameLabal;
    }
}

namespace TestTypeApp.View.Entries
{
    partial class MaterialEntry
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaterialEntry));
            this.MaterialGrid = new DevExpress.XtraGrid.GridControl();
            this.cMaterialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaterialGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.materialControl = new TestTypeApp.View.CustomControls.MaterialControl();
            this.NewButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialGrid
            // 
            this.MaterialGrid.DataSource = this.cMaterialBindingSource;
            this.MaterialGrid.Location = new System.Drawing.Point(12, 12);
            this.MaterialGrid.MainView = this.MaterialGridView;
            this.MaterialGrid.Name = "MaterialGrid";
            this.MaterialGrid.Size = new System.Drawing.Size(592, 281);
            this.MaterialGrid.TabIndex = 0;
            this.MaterialGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MaterialGridView});
            // 
            // cMaterialBindingSource
            // 
            this.cMaterialBindingSource.DataSource = typeof(TestTypeApp.Model.CMaterial);
            // 
            // MaterialGridView
            // 
            this.MaterialGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.MaterialGridView.GridControl = this.MaterialGrid;
            this.MaterialGridView.Name = "MaterialGridView";
            this.MaterialGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MaterialGridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // materialControl
            // 
            this.materialControl.DataSource = null;
            this.materialControl.Location = new System.Drawing.Point(611, 12);
            this.materialControl.MaximumSize = new System.Drawing.Size(236, 62);
            this.materialControl.Name = "materialControl";
            this.materialControl.Size = new System.Drawing.Size(236, 62);
            this.materialControl.TabIndex = 1;
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewButton.Location = new System.Drawing.Point(611, 81);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(56, 55);
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(673, 81);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 55);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(735, 81);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 55);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.RefreshButton.Location = new System.Drawing.Point(797, 80);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(56, 55);
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MaterialEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 305);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.NewButton);
            this.Controls.Add(this.materialControl);
            this.Controls.Add(this.MaterialGrid);
            this.Name = "MaterialEntry";
            this.Text = "MaterialEntry";
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl MaterialGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MaterialGridView;
        private System.Windows.Forms.BindingSource cMaterialBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private CustomControls.MaterialControl materialControl;
        private DevExpress.XtraEditors.SimpleButton NewButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
    }
}
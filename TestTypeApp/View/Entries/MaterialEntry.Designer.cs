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
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.MaterialEntryConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMaterialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialEntryConvertedLayout)).BeginInit();
            this.MaterialEntryConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
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
            this.materialControl.Location = new System.Drawing.Point(608, 12);
            this.materialControl.MaximumSize = new System.Drawing.Size(236, 62);
            this.materialControl.Name = "materialControl";
            this.materialControl.Size = new System.Drawing.Size(236, 62);
            this.materialControl.TabIndex = 1;
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewButton.Location = new System.Drawing.Point(608, 78);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(57, 55);
            this.NewButton.StyleController = this.MaterialEntryConvertedLayout;
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(669, 78);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 55);
            this.SaveButton.StyleController = this.MaterialEntryConvertedLayout;
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(729, 78);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 55);
            this.DeleteButton.StyleController = this.MaterialEntryConvertedLayout;
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.RefreshButton.Location = new System.Drawing.Point(789, 78);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(55, 55);
            this.RefreshButton.StyleController = this.MaterialEntryConvertedLayout;
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MaterialEntryConvertedLayout
            // 
            this.MaterialEntryConvertedLayout.Controls.Add(this.RefreshButton);
            this.MaterialEntryConvertedLayout.Controls.Add(this.DeleteButton);
            this.MaterialEntryConvertedLayout.Controls.Add(this.SaveButton);
            this.MaterialEntryConvertedLayout.Controls.Add(this.NewButton);
            this.MaterialEntryConvertedLayout.Controls.Add(this.materialControl);
            this.MaterialEntryConvertedLayout.Controls.Add(this.MaterialGrid);
            this.MaterialEntryConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MaterialEntryConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.MaterialEntryConvertedLayout.Name = "MaterialEntryConvertedLayout";
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.MaterialEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.MaterialEntryConvertedLayout.Root = this.layoutControlGroup1;
            this.MaterialEntryConvertedLayout.Size = new System.Drawing.Size(856, 305);
            this.MaterialEntryConvertedLayout.TabIndex = 6;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(856, 305);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.RefreshButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(777, 66);
            this.layoutControlItem1.Name = "RefreshButtonitem";
            this.layoutControlItem1.Size = new System.Drawing.Size(59, 59);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DeleteButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(717, 66);
            this.layoutControlItem2.Name = "DeleteButtonitem";
            this.layoutControlItem2.Size = new System.Drawing.Size(60, 59);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SaveButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(657, 66);
            this.layoutControlItem3.Name = "SaveButtonitem";
            this.layoutControlItem3.Size = new System.Drawing.Size(60, 59);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.NewButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(596, 66);
            this.layoutControlItem4.Name = "NewButtonitem";
            this.layoutControlItem4.Size = new System.Drawing.Size(61, 59);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.materialControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem5.Name = "MaterialControlitem";
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 66);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.MaterialGrid;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "MaterialGriditem";
            this.layoutControlItem6.Size = new System.Drawing.Size(596, 285);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(596, 125);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(61, 160);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(657, 125);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(60, 160);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(717, 125);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(60, 160);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(777, 125);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(59, 160);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MaterialEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 305);
            this.Controls.Add(this.MaterialEntryConvertedLayout);
            this.Name = "MaterialEntry";
            this.Text = "Materials";
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMaterialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaterialEntryConvertedLayout)).EndInit();
            this.MaterialEntryConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControl MaterialEntryConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
    }
}
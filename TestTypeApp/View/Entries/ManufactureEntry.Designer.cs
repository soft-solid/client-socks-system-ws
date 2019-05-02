namespace TestTypeApp.View.Entries
{
    partial class ManufactureEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManufactureEntry));
            this.ManufactureGrid = new DevExpress.XtraGrid.GridControl();
            this.cManufactureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ManufactureGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manufactureControl = new TestTypeApp.View.CustomControls.ManufactureControl();
            this.NewButton = new DevExpress.XtraEditors.SimpleButton();
            this.ManufactureEntryConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
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
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cManufactureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureEntryConvertedLayout)).BeginInit();
            this.ManufactureEntryConvertedLayout.SuspendLayout();
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
            // ManufactureGrid
            // 
            this.ManufactureGrid.DataSource = this.cManufactureBindingSource;
            this.ManufactureGrid.Location = new System.Drawing.Point(12, 12);
            this.ManufactureGrid.MainView = this.ManufactureGridView;
            this.ManufactureGrid.Name = "ManufactureGrid";
            this.ManufactureGrid.Size = new System.Drawing.Size(592, 281);
            this.ManufactureGrid.TabIndex = 0;
            this.ManufactureGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ManufactureGridView});
            // 
            // cManufactureBindingSource
            // 
            this.cManufactureBindingSource.DataSource = typeof(TestTypeApp.Model.CManufacture);
            // 
            // ManufactureGridView
            // 
            this.ManufactureGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.ManufactureGridView.GridControl = this.ManufactureGrid;
            this.ManufactureGridView.Name = "ManufactureGridView";
            this.ManufactureGridView.OptionsSelection.MultiSelect = true;
            this.ManufactureGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ManufactureGridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // manufactureControl
            // 
            this.manufactureControl.DataSource = null;
            this.manufactureControl.Location = new System.Drawing.Point(608, 12);
            this.manufactureControl.MaximumSize = new System.Drawing.Size(236, 62);
            this.manufactureControl.Name = "manufactureControl";
            this.manufactureControl.Size = new System.Drawing.Size(236, 62);
            this.manufactureControl.TabIndex = 1;
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewButton.Location = new System.Drawing.Point(608, 78);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(57, 55);
            this.NewButton.StyleController = this.ManufactureEntryConvertedLayout;
            this.NewButton.TabIndex = 2;
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // ManufactureEntryConvertedLayout
            // 
            this.ManufactureEntryConvertedLayout.Controls.Add(this.RefreshButton);
            this.ManufactureEntryConvertedLayout.Controls.Add(this.DeleteButton);
            this.ManufactureEntryConvertedLayout.Controls.Add(this.SaveButton);
            this.ManufactureEntryConvertedLayout.Controls.Add(this.NewButton);
            this.ManufactureEntryConvertedLayout.Controls.Add(this.manufactureControl);
            this.ManufactureEntryConvertedLayout.Controls.Add(this.ManufactureGrid);
            this.ManufactureEntryConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManufactureEntryConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.ManufactureEntryConvertedLayout.Name = "ManufactureEntryConvertedLayout";
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ManufactureEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.ManufactureEntryConvertedLayout.Root = this.layoutControlGroup1;
            this.ManufactureEntryConvertedLayout.Size = new System.Drawing.Size(856, 305);
            this.ManufactureEntryConvertedLayout.TabIndex = 6;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.RefreshButton.Location = new System.Drawing.Point(789, 78);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(55, 55);
            this.RefreshButton.StyleController = this.ManufactureEntryConvertedLayout;
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(729, 78);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 55);
            this.DeleteButton.StyleController = this.ManufactureEntryConvertedLayout;
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(669, 78);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(56, 55);
            this.SaveButton.StyleController = this.ManufactureEntryConvertedLayout;
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.layoutControlItem1.Name = "simpleButton4item";
            this.layoutControlItem1.Size = new System.Drawing.Size(59, 59);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DeleteButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(717, 66);
            this.layoutControlItem2.Name = "simpleButton3item";
            this.layoutControlItem2.Size = new System.Drawing.Size(60, 59);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SaveButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(657, 66);
            this.layoutControlItem3.Name = "simpleButton2item";
            this.layoutControlItem3.Size = new System.Drawing.Size(60, 59);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.NewButton;
            this.layoutControlItem4.Location = new System.Drawing.Point(596, 66);
            this.layoutControlItem4.Name = "simpleButton1item";
            this.layoutControlItem4.Size = new System.Drawing.Size(61, 59);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.manufactureControl;
            this.layoutControlItem5.Location = new System.Drawing.Point(596, 0);
            this.layoutControlItem5.Name = "ManufactureControlitem";
            this.layoutControlItem5.Size = new System.Drawing.Size(240, 66);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.ManufactureGrid;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "ManufactureGriditem";
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
            // ManufactureEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 305);
            this.Controls.Add(this.ManufactureEntryConvertedLayout);
            this.Name = "ManufactureEntry";
            this.Text = "Manufactures";
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cManufactureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ManufactureEntryConvertedLayout)).EndInit();
            this.ManufactureEntryConvertedLayout.ResumeLayout(false);
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

        private DevExpress.XtraGrid.GridControl ManufactureGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ManufactureGridView;
        private CustomControls.ManufactureControl manufactureControl;
        private DevExpress.XtraEditors.SimpleButton NewButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
        private System.Windows.Forms.BindingSource cManufactureBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraLayout.LayoutControl ManufactureEntryConvertedLayout;
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
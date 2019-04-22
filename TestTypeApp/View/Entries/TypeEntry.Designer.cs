namespace TestTypeApp.View.Entries
{
    partial class TypeEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypeEntry));
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.Typegrid = new DevExpress.XtraGrid.GridControl();
            this.cTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TypegridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NewButton = new DevExpress.XtraEditors.SimpleButton();
            this.TypeEntryConvertedLayout = new DevExpress.XtraLayout.LayoutControl();
            this.RefreshButton = new DevExpress.XtraEditors.SimpleButton();
            this.DeleteButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.typeControl = new TestTypeApp.View.TypeControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.Typegrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypegridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeEntryConvertedLayout)).BeginInit();
            this.TypeEntryConvertedLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // Typegrid
            // 
            this.Typegrid.DataSource = this.cTypeBindingSource;
            this.Typegrid.Location = new System.Drawing.Point(12, 12);
            this.Typegrid.MainView = this.TypegridView;
            this.Typegrid.Name = "Typegrid";
            this.Typegrid.Size = new System.Drawing.Size(555, 281);
            this.Typegrid.TabIndex = 0;
            this.Typegrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TypegridView});
            // 
            // cTypeBindingSource
            // 
            this.cTypeBindingSource.DataSource = typeof(TestTypeApp.Model.CType);
            // 
            // TypegridView
            // 
            this.TypegridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
            this.TypegridView.GridControl = this.Typegrid;
            this.TypegridView.Name = "TypegridView";
            this.TypegridView.OptionsSelection.MultiSelect = true;
            this.TypegridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.TypegridView_FocusedRowChanged);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // NewButton
            // 
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.NewButton.Location = new System.Drawing.Point(571, 79);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(64, 55);
            this.NewButton.StyleController = this.TypeEntryConvertedLayout;
            this.NewButton.TabIndex = 1;
            this.NewButton.Text = "New";
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // TypeEntryConvertedLayout
            // 
            this.TypeEntryConvertedLayout.Controls.Add(this.RefreshButton);
            this.TypeEntryConvertedLayout.Controls.Add(this.DeleteButton);
            this.TypeEntryConvertedLayout.Controls.Add(this.SaveButton);
            this.TypeEntryConvertedLayout.Controls.Add(this.typeControl);
            this.TypeEntryConvertedLayout.Controls.Add(this.NewButton);
            this.TypeEntryConvertedLayout.Controls.Add(this.Typegrid);
            this.TypeEntryConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeEntryConvertedLayout.Location = new System.Drawing.Point(0, 0);
            this.TypeEntryConvertedLayout.Name = "TypeEntryConvertedLayout";
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.TypeEntryConvertedLayout.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.TypeEntryConvertedLayout.Root = this.layoutControlGroup1;
            this.TypeEntryConvertedLayout.Size = new System.Drawing.Size(850, 305);
            this.TypeEntryConvertedLayout.TabIndex = 6;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.RefreshButton.Location = new System.Drawing.Point(767, 79);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(71, 55);
            this.RefreshButton.StyleController = this.TypeEntryConvertedLayout;
            this.RefreshButton.TabIndex = 5;
            this.RefreshButton.Text = "RefreshView";
            this.RefreshButton.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.DeleteButton.Location = new System.Drawing.Point(707, 79);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(56, 55);
            this.DeleteButton.StyleController = this.TypeEntryConvertedLayout;
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(639, 79);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(64, 55);
            this.SaveButton.StyleController = this.TypeEntryConvertedLayout;
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // typeControl
            // 
            this.typeControl.DataSource = null;
            this.typeControl.Location = new System.Drawing.Point(571, 12);
            this.typeControl.Name = "typeControl";
            this.typeControl.Size = new System.Drawing.Size(267, 63);
            this.typeControl.TabIndex = 2;
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
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.emptySpaceItem3,
            this.emptySpaceItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 305);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.RefreshButton;
            this.layoutControlItem1.Location = new System.Drawing.Point(755, 67);
            this.layoutControlItem1.Name = "simpleButton1item";
            this.layoutControlItem1.Size = new System.Drawing.Size(75, 59);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.DeleteButton;
            this.layoutControlItem2.Location = new System.Drawing.Point(695, 67);
            this.layoutControlItem2.Name = "DeleteButtonitem";
            this.layoutControlItem2.Size = new System.Drawing.Size(60, 59);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.SaveButton;
            this.layoutControlItem3.Location = new System.Drawing.Point(627, 67);
            this.layoutControlItem3.Name = "SaveButtonitem";
            this.layoutControlItem3.Size = new System.Drawing.Size(68, 59);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.typeControl;
            this.layoutControlItem4.Location = new System.Drawing.Point(559, 0);
            this.layoutControlItem4.Name = "TypeControlitem";
            this.layoutControlItem4.Size = new System.Drawing.Size(271, 67);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.NewButton;
            this.layoutControlItem5.Location = new System.Drawing.Point(559, 67);
            this.layoutControlItem5.Name = "NewButtonitem";
            this.layoutControlItem5.Size = new System.Drawing.Size(68, 59);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.Typegrid;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem6.Name = "Typegriditem";
            this.layoutControlItem6.Size = new System.Drawing.Size(559, 285);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(559, 126);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(68, 159);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(627, 126);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(68, 159);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(695, 126);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(60, 159);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(755, 126);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(75, 159);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // TypeEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 305);
            this.Controls.Add(this.TypeEntryConvertedLayout);
            this.Name = "TypeEntry";
            this.Text = "Types";
            ((System.ComponentModel.ISupportInitialize)(this.Typegrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypegridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeEntryConvertedLayout)).EndInit();
            this.TypeEntryConvertedLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraGrid.GridControl Typegrid;
        private DevExpress.XtraGrid.Views.Grid.GridView TypegridView;
        private DevExpress.XtraEditors.SimpleButton NewButton;
        private TypeControl typeControl;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.SimpleButton DeleteButton;
        private DevExpress.XtraEditors.SimpleButton RefreshButton;
        private DevExpress.XtraLayout.LayoutControl TypeEntryConvertedLayout;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private System.Windows.Forms.BindingSource cTypeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colName;

    }
}
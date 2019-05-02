namespace TestTypeApp.View.Entries
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.TypebarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ManufacturesbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.MaterialsbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.MenuPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.EntriesribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.TypebarButtonItem,
            this.ManufacturesbarButtonItem,
            this.MaterialsbarButtonItem,
            this.barButtonItem2});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 5;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.MenuPage});
            this.ribbonControl.Size = new System.Drawing.Size(916, 142);
            // 
            // TypebarButtonItem
            // 
            this.TypebarButtonItem.Caption = "Types";
            this.TypebarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("TypebarButtonItem.Glyph")));
            this.TypebarButtonItem.Id = 1;
            this.TypebarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("TypebarButtonItem.LargeGlyph")));
            this.TypebarButtonItem.Name = "TypebarButtonItem";
            this.TypebarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TypebarButtonItem_ItemClick);
            // 
            // ManufacturesbarButtonItem
            // 
            this.ManufacturesbarButtonItem.Caption = "Manufacures";
            this.ManufacturesbarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("ManufacturesbarButtonItem.Glyph")));
            this.ManufacturesbarButtonItem.Id = 2;
            this.ManufacturesbarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("ManufacturesbarButtonItem.LargeGlyph")));
            this.ManufacturesbarButtonItem.Name = "ManufacturesbarButtonItem";
            this.ManufacturesbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ManufacturesbarButtonItem_ItemClick);
            // 
            // MaterialsbarButtonItem
            // 
            this.MaterialsbarButtonItem.Caption = "Materials";
            this.MaterialsbarButtonItem.Glyph = ((System.Drawing.Image)(resources.GetObject("MaterialsbarButtonItem.Glyph")));
            this.MaterialsbarButtonItem.Id = 3;
            this.MaterialsbarButtonItem.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("MaterialsbarButtonItem.LargeGlyph")));
            this.MaterialsbarButtonItem.Name = "MaterialsbarButtonItem";
            this.MaterialsbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MaterialsbarButtonItem_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // MenuPage
            // 
            this.MenuPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.EntriesribbonPageGroup});
            this.MenuPage.Name = "MenuPage";
            this.MenuPage.Text = "Menu";
            // 
            // EntriesribbonPageGroup
            // 
            this.EntriesribbonPageGroup.ItemLinks.Add(this.TypebarButtonItem);
            this.EntriesribbonPageGroup.ItemLinks.Add(this.ManufacturesbarButtonItem);
            this.EntriesribbonPageGroup.ItemLinks.Add(this.MaterialsbarButtonItem);
            this.EntriesribbonPageGroup.Name = "EntriesribbonPageGroup";
            this.EntriesribbonPageGroup.Text = "Entries";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 531);
            this.Controls.Add(this.ribbonControl);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Sock\'s tracking";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraBars.BarButtonItem TypebarButtonItem;
        private DevExpress.XtraBars.BarButtonItem ManufacturesbarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage MenuPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup EntriesribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem MaterialsbarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}
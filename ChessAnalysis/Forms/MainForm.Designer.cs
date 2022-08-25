namespace ChessAnalysis.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.panel = new ChessAnalysis.Controls.MainPanel();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lciPanel = new DevExpress.XtraLayout.LayoutControlItem();
			this.Main = new DevExpress.XtraBars.Ribbon.RibbonControl();
			this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.btnSave = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.btnMail = new DevExpress.XtraBars.BarButtonItem();
			this.btnSnapshot = new DevExpress.XtraBars.BarButtonItem();
			this.btnOptions = new DevExpress.XtraBars.BarButtonItem();
			this.lblTotalPositions = new DevExpress.XtraBars.BarStaticItem();
			this.lblNotification = new DevExpress.XtraBars.BarStaticItem();
			this.toolbar = new DevExpress.XtraBars.Ribbon.RibbonPage();
			this.groupPositions = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.groupShare = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.groupOther = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
			this.statusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciPanel)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.panel);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 132);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(1198, 543);
			this.layoutControl.TabIndex = 9;
			this.layoutControl.Text = "layoutControl";
			// 
			// panel
			// 
			this.panel.Location = new System.Drawing.Point(12, 12);
			this.panel.Name = "panel";
			this.panel.ShowOnlyMainControls = false;
			this.panel.Size = new System.Drawing.Size(1174, 519);
			this.panel.TabIndex = 4;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPanel});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(1198, 543);
			this.Root.TextVisible = false;
			// 
			// lciPanel
			// 
			this.lciPanel.Control = this.panel;
			this.lciPanel.Location = new System.Drawing.Point(0, 0);
			this.lciPanel.Name = "lciPanel";
			this.lciPanel.Size = new System.Drawing.Size(1178, 523);
			this.lciPanel.TextSize = new System.Drawing.Size(0, 0);
			this.lciPanel.TextVisible = false;
			// 
			// Main
			// 
			this.Main.AllowMinimizeRibbon = false;
			this.Main.ExpandCollapseItem.Id = 0;
			this.Main.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Main.ExpandCollapseItem,
            this.Main.SearchEditItem,
            this.btnAdd,
            this.barButtonItem1,
            this.btnSave,
            this.barButtonItem2,
            this.btnMail,
            this.btnSnapshot,
            this.btnOptions,
            this.lblTotalPositions,
            this.lblNotification});
			this.Main.Location = new System.Drawing.Point(0, 0);
			this.Main.MaxItemId = 11;
			this.Main.Name = "Main";
			this.Main.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.toolbar});
			this.Main.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
			this.Main.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
			this.Main.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
			this.Main.ShowToolbarCustomizeItem = false;
			this.Main.Size = new System.Drawing.Size(1198, 132);
			this.Main.StatusBar = this.statusBar;
			this.Main.Toolbar.ShowCustomizeItem = false;
			// 
			// btnAdd
			// 
			this.btnAdd.Caption = "Add";
			this.btnAdd.Id = 1;
			this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "Add from file";
			this.barButtonItem1.Id = 2;
			this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddFromFile_ItemClick);
			// 
			// btnSave
			// 
			this.btnSave.Caption = "Save";
			this.btnSave.Id = 3;
			this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
			this.btnSave.Name = "btnSave";
			this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "Save as";
			this.barButtonItem2.Id = 4;
			this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
			this.barButtonItem2.Name = "barButtonItem2";
			this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAs_ItemClick);
			// 
			// btnMail
			// 
			this.btnMail.Caption = "Mail";
			this.btnMail.Id = 5;
			this.btnMail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMail.ImageOptions.SvgImage")));
			this.btnMail.Name = "btnMail";
			this.btnMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMail_ItemClick);
			// 
			// btnSnapshot
			// 
			this.btnSnapshot.Caption = "Snapshot";
			this.btnSnapshot.Id = 6;
			this.btnSnapshot.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSnapshot.ImageOptions.SvgImage")));
			this.btnSnapshot.Name = "btnSnapshot";
			this.btnSnapshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSnapshot_ItemClick);
			// 
			// btnOptions
			// 
			this.btnOptions.Caption = "Options";
			this.btnOptions.Id = 7;
			this.btnOptions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOptions.ImageOptions.SvgImage")));
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOptions_ItemClick);
			// 
			// lblTotalPositions
			// 
			this.lblTotalPositions.Caption = "0 row(s)";
			this.lblTotalPositions.Id = 8;
			this.lblTotalPositions.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblTotalPositions.ImageOptions.SvgImage")));
			this.lblTotalPositions.Name = "lblTotalPositions";
			this.lblTotalPositions.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// lblNotification
			// 
			this.lblNotification.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
			this.lblNotification.Id = 9;
			this.lblNotification.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblNotification.ImageOptions.SvgImage")));
			this.lblNotification.Name = "lblNotification";
			this.lblNotification.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
			// 
			// toolbar
			// 
			this.toolbar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.groupPositions,
            this.groupShare,
            this.groupOther});
			this.toolbar.Name = "toolbar";
			this.toolbar.Text = "Toolbar";
			// 
			// groupPositions
			// 
			this.groupPositions.AllowTextClipping = false;
			this.groupPositions.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
			this.groupPositions.ItemLinks.Add(this.btnAdd);
			this.groupPositions.ItemLinks.Add(this.barButtonItem1);
			this.groupPositions.ItemLinks.Add(this.btnSave);
			this.groupPositions.ItemLinks.Add(this.barButtonItem2);
			this.groupPositions.Name = "groupPositions";
			// 
			// groupShare
			// 
			this.groupShare.ItemLinks.Add(this.btnMail);
			this.groupShare.ItemLinks.Add(this.btnSnapshot);
			this.groupShare.Name = "groupShare";
			// 
			// groupOther
			// 
			this.groupOther.ItemLinks.Add(this.btnOptions);
			this.groupOther.Name = "groupOther";
			// 
			// statusBar
			// 
			this.statusBar.ItemLinks.Add(this.lblTotalPositions);
			this.statusBar.ItemLinks.Add(this.lblNotification);
			this.statusBar.Location = new System.Drawing.Point(0, 675);
			this.statusBar.Name = "statusBar";
			this.statusBar.Ribbon = this.Main;
			this.statusBar.Size = new System.Drawing.Size(1198, 24);
			// 
			// timer
			// 
			this.timer.Interval = 5000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(1198, 699);
			this.Controls.Add(this.layoutControl);
			this.Controls.Add(this.statusBar);
			this.Controls.Add(this.Main);
			this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
			this.MinimumSize = new System.Drawing.Size(1200, 700);
			this.Name = "MainForm";
			this.Ribbon = this.Main;
			this.StatusBar = this.statusBar;
			this.Text = "Chess analysis";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciPanel)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Main;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem btnSave;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraBars.BarButtonItem btnMail;
        private DevExpress.XtraBars.BarButtonItem btnSnapshot;
        private DevExpress.XtraBars.BarButtonItem btnOptions;
        private DevExpress.XtraBars.Ribbon.RibbonPage toolbar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupPositions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupShare;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupOther;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private Controls.MainPanel panel;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
        private DevExpress.XtraBars.BarStaticItem lblTotalPositions;
        private DevExpress.XtraBars.BarStaticItem lblNotification;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciPanel;
	}
}
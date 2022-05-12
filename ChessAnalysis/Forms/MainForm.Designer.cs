namespace ChessAnalysis.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.ComponentModel.ComponentResourceManager resources;

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
            this.resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Main = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.popupAdd = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnAddFromFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.popupSave = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.board = new ChessAnalysis.Controls.Board();
            this.board2 = new ChessAnalysis.Controls.Board();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBoard = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Main)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.ExpandCollapseItem.Id = 0;
            this.Main.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Main.ExpandCollapseItem,
            this.Main.SearchEditItem,
            this.btnAdd,
            this.btnAddFromFile,
            this.btnSave,
            this.btnSaveAs,
            this.btnMail,
            this.btnSnapshot,
            this.btnOptions,
            this.lblTotalPositions,
            this.lblNotification});
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.MaxItemId = 9;
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
            this.btnAdd.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnAdd.Caption = "Add";
            this.btnAdd.DropDownControl = this.popupAdd;
            this.btnAdd.Id = 1;
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // popupAdd
            // 
            this.popupAdd.ItemLinks.Add(this.btnAddFromFile);
            this.popupAdd.Name = "popupAdd";
            this.popupAdd.Ribbon = this.Main;
            // 
            // btnAddFromFile
            // 
            this.btnAddFromFile.Caption = "Add from file";
            this.btnAddFromFile.Id = 2;
            this.btnAddFromFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAddFromFile.ImageOptions.LargeImage")));
            this.btnAddFromFile.Name = "btnAddFromFile";
            this.btnAddFromFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAddFromFile_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnSave.Caption = "Save";
            this.btnSave.DropDownControl = this.popupSave;
            this.btnSave.Id = 3;
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // popupSave
            // 
            this.popupSave.ItemLinks.Add(this.btnSaveAs);
            this.popupSave.Name = "popupSave";
            this.popupSave.Ribbon = this.Main;
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Caption = "Save as";
            this.btnSaveAs.Id = 4;
            this.btnSaveAs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.ImageOptions.LargeImage")));
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveAs_ItemClick);
            // 
            // btnMail
            // 
            this.btnMail.Caption = "Mail";
            this.btnMail.Id = 5;
            this.btnMail.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMail.ImageOptions.LargeImage")));
            this.btnMail.Name = "btnMail";
            this.btnMail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMail_ItemClick);
            // 
            // btnSnapshot
            // 
            this.btnSnapshot.Caption = "Snapshot";
            this.btnSnapshot.Id = 6;
            this.btnSnapshot.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSnapshot.ImageOptions.LargeImage")));
            this.btnSnapshot.Name = "btnSnapshot";
            this.btnSnapshot.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSnapshot_ItemClick);
            // 
            // btnOptions
            // 
            this.btnOptions.Caption = "Options";
            this.btnOptions.Id = 7;
            this.btnOptions.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOptions.ImageOptions.LargeImage")));
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOptions_ItemClick);
            // 
            // lblTotalPositions
            // 
            this.lblTotalPositions.Caption = "Total positions: 0";
            this.lblTotalPositions.Id = 8;
            this.lblTotalPositions.Name = "lblTotalPositions";
            // 
            // lblNotification
            // 
            this.lblNotification.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lblNotification.Caption = "Notifications";
            this.lblNotification.Id = 9;
            this.lblNotification.Name = "lblNotification";
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
            this.groupPositions.ItemLinks.Add(this.btnSave);
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
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.board);
            this.layoutControl.Controls.Add(this.board2);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 132);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1198, 543);
            this.layoutControl.TabIndex = 9;
            this.layoutControl.Text = "layoutControl";
            // 
            // board
            // 
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(450, 519);
            this.board.TabIndex = 4;
            // 
            // board2
            // 
            this.board2.Location = new System.Drawing.Point(466, 12);
            this.board2.Name = "board2";
            this.board2.Size = new System.Drawing.Size(720, 519);
            this.board2.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBoard,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1198, 543);
            this.Root.TextVisible = false;
            // 
            // lciBoard
            // 
            this.lciBoard.Control = this.board;
            this.lciBoard.Location = new System.Drawing.Point(0, 0);
            this.lciBoard.Name = "lciBoard";
            this.lciBoard.Size = new System.Drawing.Size(454, 523);
            this.lciBoard.TextSize = new System.Drawing.Size(0, 0);
            this.lciBoard.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.board2;
            this.layoutControlItem2.Location = new System.Drawing.Point(454, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(724, 523);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1198, 699);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.layoutControl);
            this.Controls.Add(this.statusBar);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "MainForm";
            this.Ribbon = this.Main;
            this.StatusBar = this.statusBar;
            this.Text = "Chess analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Main)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl Main;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.PopupMenu popupAdd;
        private DevExpress.XtraBars.BarButtonItem btnAddFromFile;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.PopupMenu popupSave;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.XtraBars.BarButtonItem btnMail;
        private DevExpress.XtraBars.BarButtonItem btnSnapshot;
        private DevExpress.XtraBars.BarButtonItem btnOptions;
        private DevExpress.XtraBars.Ribbon.RibbonPage toolbar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupPositions;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupShare;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup groupOther;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private Controls.Board board;
        private Controls.Board board2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar statusBar;
        private DevExpress.XtraBars.BarStaticItem lblTotalPositions;
        private DevExpress.XtraBars.BarStaticItem lblNotification;        
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciBoard;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}
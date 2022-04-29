namespace ChessAnalysis.Forms
{
    partial class OptionsForm
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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.navigation = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.itemParent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemBoard = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageGeneral = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.generalTab = new ChessAnalysis.Controls.GeneralTab();
            this.pageBoard = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.boardTab = new ChessAnalysis.Controls.BoardTab();
            this.btnDefaults = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNavigation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNavigationFrame = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDefaults = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.pageGeneral.SuspendLayout();
            this.pageBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.navigation);
            this.layoutControl.Controls.Add(this.navigationFrame);
            this.layoutControl.Controls.Add(this.btnDefaults);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(506, 382);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // navigation
            // 
            this.navigation.AllowItemSelection = true;
            this.navigation.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None;
            this.navigation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemParent});
            this.navigation.Location = new System.Drawing.Point(12, 12);
            this.navigation.Name = "navigation";
            this.navigation.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.navigation.ShowGroupExpandButtons = false;
            this.navigation.Size = new System.Drawing.Size(76, 300);
            this.navigation.StyleController = this.layoutControl;
            this.navigation.TabIndex = 1;
            // 
            // itemParent
            // 
            this.itemParent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemGeneral,
            this.itemBoard});
            this.itemParent.Expanded = true;
            this.itemParent.HeaderVisible = false;
            this.itemParent.Name = "itemParent";
            this.itemParent.Text = "itemParent";
            // 
            // itemGeneral
            // 
            this.itemGeneral.Name = "itemGeneral";
            this.itemGeneral.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemGeneral.Text = "General";
            // 
            // itemBoard
            // 
            this.itemBoard.Name = "itemBoard";
            this.itemBoard.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemBoard.Text = "Board";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.pageGeneral);
            this.navigationFrame.Controls.Add(this.pageBoard);
            this.navigationFrame.Location = new System.Drawing.Point(92, 12);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageGeneral,
            this.pageBoard});
            this.navigationFrame.SelectedPage = this.pageGeneral;
            this.navigationFrame.Size = new System.Drawing.Size(400, 300);
            this.navigationFrame.TabIndex = 2;
            this.navigationFrame.Text = "navigationFrame";
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 50;
            // 
            // pageGeneral
            // 
            this.pageGeneral.Caption = "pageGeneral";
            this.pageGeneral.Controls.Add(this.generalTab);
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Size = new System.Drawing.Size(400, 300);
            // 
            // generalTab
            // 
            this.generalTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTab.Location = new System.Drawing.Point(0, 0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(400, 300);
            this.generalTab.TabIndex = 3;
            // 
            // pageBoard
            // 
            this.pageBoard.Caption = "pageBoard";
            this.pageBoard.Controls.Add(this.boardTab);
            this.pageBoard.Name = "pageBoard";
            this.pageBoard.Size = new System.Drawing.Size(400, 300);
            // 
            // boardTab
            // 
            this.boardTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardTab.Location = new System.Drawing.Point(0, 0);
            this.boardTab.Name = "boardTab";
            this.boardTab.Size = new System.Drawing.Size(400, 300);
            this.boardTab.TabIndex = 4;
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(12, 316);
            this.btnDefaults.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(76, 22);
            this.btnDefaults.StyleController = this.layoutControl;
            this.btnDefaults.TabIndex = 5;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNavigation,
            this.lciNavigationFrame,
            this.lciDefaults,
            this.emptySpaceItem});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(506, 382);
            this.Root.TextVisible = false;
            // 
            // lciNavigation
            // 
            this.lciNavigation.Control = this.navigation;
            this.lciNavigation.Location = new System.Drawing.Point(0, 0);
            this.lciNavigation.MinSize = new System.Drawing.Size(54, 20);
            this.lciNavigation.Name = "lciNavigation";
            this.lciNavigation.Size = new System.Drawing.Size(80, 304);
            this.lciNavigation.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNavigation.TextSize = new System.Drawing.Size(0, 0);
            this.lciNavigation.TextVisible = false;
            // 
            // lciNavigationFrame
            // 
            this.lciNavigationFrame.Control = this.navigationFrame;
            this.lciNavigationFrame.Location = new System.Drawing.Point(80, 0);
            this.lciNavigationFrame.MinSize = new System.Drawing.Size(104, 24);
            this.lciNavigationFrame.Name = "lciNavigationFrame";
            this.lciNavigationFrame.Size = new System.Drawing.Size(404, 304);
            this.lciNavigationFrame.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNavigationFrame.TextSize = new System.Drawing.Size(0, 0);
            this.lciNavigationFrame.TextVisible = false;
            // 
            // lciDefaults
            // 
            this.lciDefaults.Control = this.btnDefaults;
            this.lciDefaults.Location = new System.Drawing.Point(0, 304);
            this.lciDefaults.Name = "lciDefaults";
            this.lciDefaults.Size = new System.Drawing.Size(80, 26);
            this.lciDefaults.TextSize = new System.Drawing.Size(0, 0);
            this.lciDefaults.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(80, 304);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(404, 26);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(504, 350);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.pageGeneral.ResumeLayout(false);
            this.pageBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraBars.Navigation.AccordionControl navigation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemParent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemGeneral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemBoard;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage pageGeneral;
        private Controls.GeneralTab generalTab;
        private DevExpress.XtraBars.Navigation.NavigationPage pageBoard;
        private Controls.BoardTab boardTab;
        private DevExpress.XtraEditors.SimpleButton btnDefaults;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciNavigation;
        private DevExpress.XtraLayout.LayoutControlItem lciNavigationFrame;
        private DevExpress.XtraLayout.LayoutControlItem lciDefaults;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
    }
}
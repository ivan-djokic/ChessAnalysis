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
            this.itemMail = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.pageGeneral = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.generalTab = new ChessAnalysis.Controls.GeneralTab();
            this.pageBoard = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.boardTab = new ChessAnalysis.Controls.BoardTab();
            this.pageMail = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.mailTab = new ChessAnalysis.Controls.MailTab();
            this.btnDefaults = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNavigation = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNavigationFrame = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDefaults = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.pageGeneral.SuspendLayout();
            this.pageBoard.SuspendLayout();
            this.pageMail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigationFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaults)).BeginInit();
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
            this.layoutControl.Size = new System.Drawing.Size(508, 348);
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
            this.navigation.Size = new System.Drawing.Size(62, 298);
            this.navigation.StyleController = this.layoutControl;
            this.navigation.TabIndex = 1;
            // 
            // itemParent
            // 
            this.itemParent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemGeneral,
            this.itemBoard,
            this.itemMail});
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
            // itemMail
            // 
            this.itemMail.Name = "itemMail";
            this.itemMail.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemMail.Text = "Mail";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.pageGeneral);
            this.navigationFrame.Controls.Add(this.pageBoard);
            this.navigationFrame.Controls.Add(this.pageMail);
            this.navigationFrame.Location = new System.Drawing.Point(78, 12);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageGeneral,
            this.pageBoard,
            this.pageMail});
            this.navigationFrame.SelectedPage = this.pageGeneral;
            this.navigationFrame.Size = new System.Drawing.Size(418, 298);
            this.navigationFrame.TabIndex = 2;
            this.navigationFrame.Text = "navigationFrame";
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 50;
            // 
            // pageGeneral
            // 
            this.pageGeneral.Caption = "pageGeneral";
            this.pageGeneral.Controls.Add(this.generalTab);
            this.pageGeneral.Name = "pageGeneral";
            this.pageGeneral.Size = new System.Drawing.Size(418, 298);
            // 
            // generalTab
            // 
            this.generalTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTab.Location = new System.Drawing.Point(0, 0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(418, 298);
            this.generalTab.TabIndex = 3;
            // 
            // pageBoard
            // 
            this.pageBoard.Caption = "pageBoard";
            this.pageBoard.Controls.Add(this.boardTab);
            this.pageBoard.Name = "pageBoard";
            this.pageBoard.Size = new System.Drawing.Size(418, 298);
            // 
            // boardTab
            // 
            this.boardTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boardTab.Location = new System.Drawing.Point(0, 0);
            this.boardTab.Name = "boardTab";
            this.boardTab.Size = new System.Drawing.Size(418, 298);
            this.boardTab.TabIndex = 4;
            // 
            // pageMail
            // 
            this.pageMail.Caption = "pageMail";
            this.pageMail.Controls.Add(this.mailTab);
            this.pageMail.Name = "pageMail";
            this.pageMail.Size = new System.Drawing.Size(418, 298);
            // 
            // mailTab
            // 
            this.mailTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mailTab.Location = new System.Drawing.Point(0, 0);
            this.mailTab.Name = "mailTab";
            this.mailTab.Size = new System.Drawing.Size(418, 298);
            this.mailTab.TabIndex = 5;
            // 
            // btnDefaults
            // 
            this.btnDefaults.AllowFocus = false;
            this.btnDefaults.Location = new System.Drawing.Point(420, 314);
            this.btnDefaults.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(76, 22);
            this.btnDefaults.StyleController = this.layoutControl;
            this.btnDefaults.TabIndex = 6;
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
            this.lciDefaults});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(508, 348);
            this.Root.TextVisible = false;
            // 
            // lciNavigation
            // 
            this.lciNavigation.Control = this.navigation;
            this.lciNavigation.Location = new System.Drawing.Point(0, 0);
            this.lciNavigation.MinSize = new System.Drawing.Size(54, 20);
            this.lciNavigation.Name = "lciNavigation";
            this.lciNavigation.Size = new System.Drawing.Size(66, 302);
            this.lciNavigation.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNavigation.TextSize = new System.Drawing.Size(0, 0);
            this.lciNavigation.TextVisible = false;
            // 
            // lciNavigationFrame
            // 
            this.lciNavigationFrame.Control = this.navigationFrame;
            this.lciNavigationFrame.Location = new System.Drawing.Point(66, 0);
            this.lciNavigationFrame.MinSize = new System.Drawing.Size(104, 24);
            this.lciNavigationFrame.Name = "lciNavigationFrame";
            this.lciNavigationFrame.Size = new System.Drawing.Size(422, 302);
            this.lciNavigationFrame.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNavigationFrame.TextSize = new System.Drawing.Size(0, 0);
            this.lciNavigationFrame.TextVisible = false;
            // 
            // lciDefaults
            // 
            this.lciDefaults.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciDefaults.Control = this.btnDefaults;
            this.lciDefaults.Location = new System.Drawing.Point(0, 302);
            this.lciDefaults.Name = "lciDefaults";
            this.lciDefaults.Size = new System.Drawing.Size(488, 26);
            this.lciDefaults.TextSize = new System.Drawing.Size(0, 0);
            this.lciDefaults.TextVisible = false;
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(508, 348);
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
            this.pageMail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNavigationFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefaults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraBars.Navigation.AccordionControl navigation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemParent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemGeneral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemBoard;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemMail;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage pageGeneral;
        private DevExpress.XtraBars.Navigation.NavigationPage pageBoard;
        private DevExpress.XtraBars.Navigation.NavigationPage pageMail;
        private Controls.GeneralTab generalTab;
        private Controls.BoardTab boardTab;
        private Controls.MailTab mailTab;
        private DevExpress.XtraEditors.SimpleButton btnDefaults;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciNavigation;
        private DevExpress.XtraLayout.LayoutControlItem lciNavigationFrame;
        private DevExpress.XtraLayout.LayoutControlItem lciDefaults;
    }
}
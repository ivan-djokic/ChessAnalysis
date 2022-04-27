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
            this.navigation = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.itemParent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemGeneral = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.itemShortcuts = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnDefaults = new DevExpress.XtraEditors.SimpleButton();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationGeneral = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.generalTab = new ChessAnalysis.Controls.GeneralTab();
            this.navigationShortcuts = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.shortcutsTab = new ChessAnalysis.Controls.GeneralTab();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.navigationGeneral.SuspendLayout();
            this.navigationShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // navigation
            // 
            this.navigation.AllowItemSelection = true;
            this.navigation.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None;
            this.navigation.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemParent});
            this.navigation.Location = new System.Drawing.Point(9, 8);
            this.navigation.Name = "navigation";
            this.navigation.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.navigation.ShowGroupExpandButtons = false;
            this.navigation.SelectedElement = itemGeneral;
            this.navigation.Size = new System.Drawing.Size(76, 294);
            this.navigation.StyleController = this.layoutControl;
            this.navigation.TabIndex = 0;
            this.navigation.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.navigation_SelectedElementChanged);
            // 
            // itemParent
            // 
            this.itemParent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemGeneral,
            this.itemShortcuts});
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
            // itemShortcuts
            // 
            this.itemShortcuts.Name = "itemShortcuts";
            this.itemShortcuts.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.itemShortcuts.Text = "Shortcuts";
            // 
            // layoutControl
            // 
            this.layoutControl.AllowCustomization = false;
            this.layoutControl.Controls.Add(this.btnCancel);
            this.layoutControl.Controls.Add(this.btnOk);
            this.layoutControl.Controls.Add(this.btnDefaults);
            this.layoutControl.Controls.Add(this.navigationFrame);
            this.layoutControl.Controls.Add(this.navigation);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(966, 296, 586, 640);
            this.layoutControl.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl.Root = this.layoutControlGroup1;
            this.layoutControl.Size = new System.Drawing.Size(498, 338);
            this.layoutControl.TabIndex = 1;
            this.layoutControl.Text = "layoutControl";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(413, 306);
            this.btnCancel.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnCancel.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 22);
            this.btnCancel.StyleController = this.layoutControl;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // btnOk
            // 
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(328, 306);
            this.btnOk.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnOk.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(76, 22);
            this.btnOk.StyleController = this.layoutControl;
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "OK";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(9, 306);
            this.btnDefaults.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(76, 22);
            this.btnDefaults.StyleController = this.layoutControl;
            this.btnDefaults.TabIndex = 5;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.navigationGeneral);
            this.navigationFrame.Controls.Add(this.navigationShortcuts);
            this.navigationFrame.Location = new System.Drawing.Point(89, 2);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationGeneral,
            this.navigationShortcuts});
            this.navigationFrame.SelectedPage = this.navigationGeneral;
            this.navigationFrame.Size = new System.Drawing.Size(400, 300);
            this.navigationFrame.TabIndex = 4;
            this.navigationFrame.Text = "navigationFrame";
            this.navigationFrame.TransitionAnimationProperties.FrameCount = 50;
            // 
            // navigationGeneral
            // 
            this.navigationGeneral.Caption = "navigationGeneral";
            this.navigationGeneral.Controls.Add(this.generalTab);
            this.navigationGeneral.Name = "navigationGeneral";
            this.navigationGeneral.Size = new System.Drawing.Size(400, 300);
            // 
            // generalTab
            // 
            this.generalTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.generalTab.Location = new System.Drawing.Point(0, 0);
            this.generalTab.Name = "generalTab";
            this.generalTab.Size = new System.Drawing.Size(400, 300);
            this.generalTab.TabIndex = 0;
            // 
            // navigationShortcuts
            // 
            this.navigationShortcuts.Caption = "navigationShortcuts";
            this.navigationShortcuts.Controls.Add(this.shortcutsTab);
            this.navigationShortcuts.Name = "navigationShortcuts";
            this.navigationShortcuts.Size = new System.Drawing.Size(400, 300);
            // 
            // shortcutsTab
            // 
            this.shortcutsTab.Location = new System.Drawing.Point(3, 3);
            this.shortcutsTab.Name = "shortcutsTab";
            this.shortcutsTab.Size = new System.Drawing.Size(394, 299);
            this.shortcutsTab.TabIndex = 0;
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
            this.emptySpaceItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(7, 7, 0, 8);
            this.layoutControlGroup1.Size = new System.Drawing.Size(498, 338);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.navigation;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(54, 20);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2);
            this.layoutControlItem1.Size = new System.Drawing.Size(80, 304);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.navigationFrame;
            this.layoutControlItem2.Location = new System.Drawing.Point(80, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(404, 304);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnDefaults;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 304);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnOk;
            this.layoutControlItem4.Location = new System.Drawing.Point(319, 304);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 7, 2, 2);
            this.layoutControlItem4.Size = new System.Drawing.Size(85, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(404, 304);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(80, 304);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(239, 26);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // OptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(498, 338);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OptionsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Options";
            ((System.ComponentModel.ISupportInitialize)(this.navigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.navigationGeneral.ResumeLayout(false);
            this.navigationShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl navigation;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemParent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemGeneral;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemShortcuts;
        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationGeneral;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationShortcuts;
        private Controls.GeneralTab generalTab;
        private Controls.GeneralTab shortcutsTab;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnDefaults;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOk;
    }
}
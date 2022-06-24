namespace ChessAnalysis.Forms
{
    partial class SelectDataAmountForm
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
			this.selection = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.itemParent = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.itemSelectedOnly = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.itemAll = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.chxDontShowAgain = new DevExpress.XtraEditors.CheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lciSelection = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciDontShowAgain = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.selection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chxDontShowAgain.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSelection)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciDontShowAgain)).BeginInit();
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.AllowCustomization = false;
			this.layoutControl.Controls.Add(this.selection);
			this.layoutControl.Controls.Add(this.chxDontShowAgain);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(158, 111);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "layoutControl";
			// 
			// selection
			// 
			this.selection.AllowItemSelection = true;
			this.selection.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.None;
			this.selection.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemParent});
			this.selection.Location = new System.Drawing.Point(12, 12);
			this.selection.Name = "selection";
			this.selection.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
			this.selection.ShowGroupExpandButtons = false;
			this.selection.Size = new System.Drawing.Size(134, 63);
			this.selection.StyleController = this.layoutControl;
			this.selection.TabIndex = 1;
			this.selection.SelectedElementChanged += new DevExpress.XtraBars.Navigation.SelectedElementChangedEventHandler(this.selection_SelectedElementChanged);
			// 
			// itemParent
			// 
			this.itemParent.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.itemSelectedOnly,
            this.itemAll});
			this.itemParent.Expanded = true;
			this.itemParent.HeaderVisible = false;
			this.itemParent.Name = "itemParent";
			this.itemParent.Text = "itemParent";
			// 
			// itemSelectedOnly
			// 
			this.itemSelectedOnly.Name = "itemSelectedOnly";
			this.itemSelectedOnly.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.itemSelectedOnly.Text = "Only selected data";
			// 
			// itemAll
			// 
			this.itemAll.Name = "itemAll";
			this.itemAll.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.itemAll.Text = "All data";
			// 
			// chxDontShowAgain
			// 
			this.chxDontShowAgain.Location = new System.Drawing.Point(12, 79);
			this.chxDontShowAgain.Name = "chxDontShowAgain";
			this.chxDontShowAgain.Properties.AllowFocused = false;
			this.chxDontShowAgain.Properties.Caption = "Don\'t show again";
			this.chxDontShowAgain.Size = new System.Drawing.Size(134, 20);
			this.chxDontShowAgain.StyleController = this.layoutControl;
			this.chxDontShowAgain.TabIndex = 2;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSelection,
            this.lciDontShowAgain});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(158, 111);
			this.Root.TextVisible = false;
			// 
			// lciSelection
			// 
			this.lciSelection.Control = this.selection;
			this.lciSelection.Location = new System.Drawing.Point(0, 0);
			this.lciSelection.MinSize = new System.Drawing.Size(54, 20);
			this.lciSelection.Name = "lciSelection";
			this.lciSelection.Size = new System.Drawing.Size(138, 67);
			this.lciSelection.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.lciSelection.TextSize = new System.Drawing.Size(0, 0);
			this.lciSelection.TextVisible = false;
			// 
			// lciDontShowAgain
			// 
			this.lciDontShowAgain.Control = this.chxDontShowAgain;
			this.lciDontShowAgain.Location = new System.Drawing.Point(0, 67);
			this.lciDontShowAgain.Name = "lciDontShowAgain";
			this.lciDontShowAgain.Size = new System.Drawing.Size(138, 24);
			this.lciDontShowAgain.TextSize = new System.Drawing.Size(0, 0);
			this.lciDontShowAgain.TextVisible = false;
			// 
			// SelectDataAmountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(158, 111);
			this.Controls.Add(this.layoutControl);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.IconOptions.ShowIcon = false;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SelectDataAmountForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Select data amount";
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.selection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chxDontShowAgain.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSelection)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciDontShowAgain)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraBars.Navigation.AccordionControl selection;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemParent;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemSelectedOnly;
        private DevExpress.XtraBars.Navigation.AccordionControlElement itemAll;
		private DevExpress.XtraEditors.CheckEdit chxDontShowAgain;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciSelection;
		private DevExpress.XtraLayout.LayoutControlItem lciDontShowAgain;
	}
}
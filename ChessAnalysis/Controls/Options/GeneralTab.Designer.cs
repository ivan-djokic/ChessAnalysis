namespace ChessAnalysis.Controls
{
    partial class GeneralTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.rbLight = new DevExpress.XtraEditors.CheckEdit();
            this.rbDark = new DevExpress.XtraEditors.CheckEdit();
            this.lblTheme = new DevExpress.XtraEditors.LabelControl();
            this.txtSnapshotDirectory = new DevExpress.XtraEditors.ButtonEdit();
            this.lblOutput = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciOutput = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciSnapshotDirectory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTheme = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDark = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLight = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbLight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapshotDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSnapshotDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLight)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.rbLight);
            this.layoutControl.Controls.Add(this.rbDark);
            this.layoutControl.Controls.Add(this.lblTheme);
            this.layoutControl.Controls.Add(this.txtSnapshotDirectory);
            this.layoutControl.Controls.Add(this.lblOutput);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(400, 300);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // rbLight
            // 
            this.rbLight.Location = new System.Drawing.Point(81, 87);
            this.rbLight.Name = "rbLight";
            this.rbLight.Properties.Caption = "Light";
            this.rbLight.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.rbLight.Properties.RadioGroupIndex = 1;
            this.rbLight.Size = new System.Drawing.Size(307, 20);
            this.rbLight.StyleController = this.layoutControl;
            this.rbLight.TabIndex = 8;
            this.rbLight.TabStop = false;
            // 
            // rbDark
            // 
            this.rbDark.EditValue = true;
            this.rbDark.Location = new System.Drawing.Point(32, 87);
            this.rbDark.Name = "rbDark";
            this.rbDark.Properties.Caption = "Dark";
            this.rbDark.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.rbDark.Properties.RadioGroupIndex = 1;
            this.rbDark.Size = new System.Drawing.Size(45, 20);
            this.rbDark.StyleController = this.layoutControl;
            this.rbDark.TabIndex = 7;
            // 
            // lblTheme
            // 
            this.lblTheme.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTheme.Appearance.Options.UseFont = true;
            this.lblTheme.Location = new System.Drawing.Point(12, 64);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(49, 19);
            this.lblTheme.StyleController = this.layoutControl;
            this.lblTheme.TabIndex = 6;
            this.lblTheme.Text = "Theme";
            // 
            // txtSnapshotDirectory
            // 
            this.txtSnapshotDirectory.Location = new System.Drawing.Point(177, 35);
            this.txtSnapshotDirectory.Name = "txtSnapshotDirectory";
            this.txtSnapshotDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)});
            this.txtSnapshotDirectory.Size = new System.Drawing.Size(211, 20);
            this.txtSnapshotDirectory.StyleController = this.layoutControl;
            this.txtSnapshotDirectory.TabIndex = 5;
            this.txtSnapshotDirectory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSnapshotDirectory_ButtonClick);
            // 
            // lblOutput
            // 
            this.lblOutput.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Appearance.Options.UseFont = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(49, 19);
            this.lblOutput.StyleController = this.layoutControl;
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciOutput,
            this.emptySpaceItem,
            this.lciSnapshotDirectory,
            this.lciTheme,
            this.lciDark,
            this.lciLight});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(400, 300);
            this.Root.TextVisible = false;
            // 
            // lciOutput
            // 
            this.lciOutput.Control = this.lblOutput;
            this.lciOutput.Location = new System.Drawing.Point(0, 0);
            this.lciOutput.Name = "lciOutput";
            this.lciOutput.Size = new System.Drawing.Size(380, 23);
            this.lciOutput.TextSize = new System.Drawing.Size(0, 0);
            this.lciOutput.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 107);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(380, 173);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciSnapshotDirectory
            // 
            this.lciSnapshotDirectory.Control = this.txtSnapshotDirectory;
            this.lciSnapshotDirectory.Location = new System.Drawing.Point(0, 23);
            this.lciSnapshotDirectory.Name = "lciSnapshotDirectory";
            this.lciSnapshotDirectory.Size = new System.Drawing.Size(380, 24);
            this.lciSnapshotDirectory.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciSnapshotDirectory.Text = "Default Snapshot directory:";
            this.lciSnapshotDirectory.TextSize = new System.Drawing.Size(133, 13);
            // 
            // lciTheme
            // 
            this.lciTheme.Control = this.lblTheme;
            this.lciTheme.Location = new System.Drawing.Point(0, 47);
            this.lciTheme.Name = "lciTheme";
            this.lciTheme.Size = new System.Drawing.Size(380, 28);
            this.lciTheme.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.lciTheme.TextSize = new System.Drawing.Size(0, 0);
            this.lciTheme.TextVisible = false;
            // 
            // lciDark
            // 
            this.lciDark.Control = this.rbDark;
            this.lciDark.Location = new System.Drawing.Point(0, 75);
            this.lciDark.Name = "lciDark";
            this.lciDark.Size = new System.Drawing.Size(69, 24);
            this.lciDark.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciDark.TextSize = new System.Drawing.Size(0, 0);
            this.lciDark.TextVisible = false;
            // 
            // lciLight
            // 
            this.lciLight.Control = this.rbLight;
            this.lciLight.Location = new System.Drawing.Point(69, 75);
            this.lciLight.Name = "lciLight";
            this.lciLight.Size = new System.Drawing.Size(311, 24);
            this.lciLight.TextSize = new System.Drawing.Size(0, 0);
            this.lciLight.TextVisible = false;
            // 
            // GeneralTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl);
            this.Name = "GeneralTab";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rbLight.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapshotDirectory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSnapshotDirectory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTheme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblOutput;
        private DevExpress.XtraLayout.LayoutControlItem lciOutput;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraEditors.ButtonEdit txtSnapshotDirectory;
        private DevExpress.XtraLayout.LayoutControlItem lciSnapshotDirectory;
        private DevExpress.XtraEditors.LabelControl lblTheme;
        private DevExpress.XtraLayout.LayoutControlItem lciTheme;
        private DevExpress.XtraEditors.CheckEdit rbDark;
        private DevExpress.XtraLayout.LayoutControlItem lciDark;
        private DevExpress.XtraEditors.CheckEdit rbLight;
        private DevExpress.XtraLayout.LayoutControlItem lciLight;
    }
}

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
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralTab));
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
			this.lblInput = new DevExpress.XtraEditors.LabelControl();
			this.chxShortInput = new DevExpress.XtraEditors.CheckEdit();
			this.lblOutput = new DevExpress.XtraEditors.LabelControl();
			this.txtSnapshotDirectory = new DevExpress.XtraEditors.ButtonEdit();
			this.lblTheme = new DevExpress.XtraEditors.LabelControl();
			this.rbDark = new DevExpress.XtraEditors.CheckEdit();
			this.rbLight = new DevExpress.XtraEditors.CheckEdit();
			this.lblSound = new DevExpress.XtraEditors.LabelControl();
			this.chxPlaySound = new DevExpress.XtraEditors.CheckEdit();
			this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
			this.lciInput = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciShortInput = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciOutput = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciSnapshotDirectory = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciTheme = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciDark = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciLight = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciSound = new DevExpress.XtraLayout.LayoutControlItem();
			this.lciPlaySound = new DevExpress.XtraLayout.LayoutControlItem();
			this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
			this.layoutControl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chxShortInput.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtSnapshotDirectory.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbDark.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rbLight.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chxPlaySound.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciShortInput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciOutput)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSnapshotDirectory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciTheme)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciDark)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciLight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSound)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lciPlaySound)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
			
			this.SuspendLayout();
			// 
			// layoutControl
			// 
			this.layoutControl.Controls.Add(this.lblInput);
			this.layoutControl.Controls.Add(this.chxShortInput);
			this.layoutControl.Controls.Add(this.lblOutput);
			this.layoutControl.Controls.Add(this.txtSnapshotDirectory);
			this.layoutControl.Controls.Add(this.lblTheme);
			this.layoutControl.Controls.Add(this.rbDark);
			this.layoutControl.Controls.Add(this.rbLight);
			this.layoutControl.Controls.Add(this.lblSound);
			this.layoutControl.Controls.Add(this.chxPlaySound);
			this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl.Location = new System.Drawing.Point(0, 0);
			this.layoutControl.Name = "layoutControl";
			this.layoutControl.Root = this.Root;
			this.layoutControl.Size = new System.Drawing.Size(400, 300);
			this.layoutControl.TabIndex = 0;
			this.layoutControl.Text = "layoutControl";
			// 
			// lblInput
			// 
			this.lblInput.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblInput.Appearance.Options.UseFont = true;
			this.lblInput.Location = new System.Drawing.Point(12, 12);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(35, 18);
			this.lblInput.StyleController = this.layoutControl;
			this.lblInput.TabIndex = 11;
			this.lblInput.Text = "Input";
			// 
			// chxShortInput
			// 
			this.chxShortInput.Location = new System.Drawing.Point(32, 34);
			this.chxShortInput.Name = "chxShortInput";
			this.chxShortInput.Properties.AllowFocused = false;
			this.chxShortInput.Properties.Caption = "Use short input standard";
			this.chxShortInput.Size = new System.Drawing.Size(356, 20);
			this.chxShortInput.StyleController = this.layoutControl;
			this.chxShortInput.TabIndex = 12;
			// 
			// lblOutput
			// 
			this.lblOutput.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblOutput.Appearance.Options.UseFont = true;
			this.lblOutput.Location = new System.Drawing.Point(12, 58);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(45, 18);
			this.lblOutput.StyleController = this.layoutControl;
			this.lblOutput.TabIndex = 1;
			this.lblOutput.Text = "Output";
			// 
			// txtSnapshotDirectory
			// 
			this.txtSnapshotDirectory.EditValue = "C:\\Users\\User\\Documents\\Chess Analysis\\Snapshots";
			this.txtSnapshotDirectory.Location = new System.Drawing.Point(139, 80);
			this.txtSnapshotDirectory.Name = "txtSnapshotDirectory";
			this.txtSnapshotDirectory.Properties.AllowFocused = false;
			editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
			editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(12, 12);
			this.txtSnapshotDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.txtSnapshotDirectory.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
			this.txtSnapshotDirectory.Size = new System.Drawing.Size(249, 20);
			this.txtSnapshotDirectory.StyleController = this.layoutControl;
			this.txtSnapshotDirectory.TabIndex = 2;
			this.txtSnapshotDirectory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSnapshotDirectory_ButtonClick);
			// 
			// lblTheme
			// 
			this.lblTheme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblTheme.Appearance.Options.UseFont = true;
			this.lblTheme.Location = new System.Drawing.Point(12, 109);
			this.lblTheme.Name = "lblTheme";
			this.lblTheme.Size = new System.Drawing.Size(47, 18);
			this.lblTheme.StyleController = this.layoutControl;
			this.lblTheme.TabIndex = 3;
			this.lblTheme.Text = "Theme";
			// 
			// rbDark
			// 
			this.rbDark.EditValue = true;
			this.rbDark.Location = new System.Drawing.Point(32, 131);
			this.rbDark.Name = "rbDark";
			this.rbDark.Properties.AllowFocused = false;
			this.rbDark.Properties.Caption = "Dark";
			this.rbDark.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.rbDark.Properties.RadioGroupIndex = 0;
			this.rbDark.Size = new System.Drawing.Size(46, 20);
			this.rbDark.StyleController = this.layoutControl;
			this.rbDark.TabIndex = 4;
			// 
			// rbLight
			// 
			this.rbLight.Location = new System.Drawing.Point(82, 131);
			this.rbLight.Name = "rbLight";
			this.rbLight.Properties.AllowFocused = false;
			this.rbLight.Properties.Caption = "Light";
			this.rbLight.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
			this.rbLight.Properties.RadioGroupIndex = 0;
			this.rbLight.Size = new System.Drawing.Size(306, 20);
			this.rbLight.StyleController = this.layoutControl;
			this.rbLight.TabIndex = 5;
			this.rbLight.TabStop = false;
			// 
			// lblSound
			// 
			this.lblSound.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSound.Appearance.Options.UseFont = true;
			this.lblSound.Location = new System.Drawing.Point(12, 160);
			this.lblSound.Name = "lblSound";
			this.lblSound.Size = new System.Drawing.Size(40, 18);
			this.lblSound.StyleController = this.layoutControl;
			this.lblSound.TabIndex = 9;
			this.lblSound.Text = "Sound";
			// 
			// chxPlaySound
			// 
			this.chxPlaySound.EditValue = true;
			this.chxPlaySound.Location = new System.Drawing.Point(32, 182);
			this.chxPlaySound.Name = "chxPlaySound";
			this.chxPlaySound.Properties.AllowFocused = false;
			this.chxPlaySound.Properties.Caption = "Play sounds in application";
			this.chxPlaySound.Size = new System.Drawing.Size(356, 20);
			this.chxPlaySound.StyleController = this.layoutControl;
			this.chxPlaySound.TabIndex = 10;
			// 
			// Root
			// 
			this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.Root.GroupBordersVisible = false;
			this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
			this.lciInput,
			this.lciShortInput,
			this.lciOutput,
            this.lciSnapshotDirectory,
            this.lciTheme,
            this.lciDark,
            this.lciLight,
            this.lciSound,
            this.lciPlaySound,
            this.emptySpaceItem});
			this.Root.Name = "Root";
			this.Root.Size = new System.Drawing.Size(400, 300);
			this.Root.TextVisible = false;
			// 
			// lciInput
			// 
			this.lciInput.Control = this.lblInput;
			this.lciInput.Location = new System.Drawing.Point(0, 0);
			this.lciInput.Name = "lciInput";
			this.lciInput.Size = new System.Drawing.Size(380, 22);
			this.lciInput.TextSize = new System.Drawing.Size(0, 0);
			this.lciInput.TextVisible = false;
			// 
			// lciShortInput
			// 
			this.lciShortInput.Control = this.chxShortInput;
			this.lciShortInput.Location = new System.Drawing.Point(0, 22);
			this.lciShortInput.Name = "lciShortInput";
			this.lciShortInput.Size = new System.Drawing.Size(380, 24);
			this.lciShortInput.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
			this.lciShortInput.TextSize = new System.Drawing.Size(0, 0);
			this.lciShortInput.TextVisible = false;
			// 
			// lciOutput
			// 
			this.lciOutput.Control = this.lblOutput;
			this.lciOutput.Location = new System.Drawing.Point(0, 46);
			this.lciOutput.Name = "lciOutput";
			this.lciOutput.Size = new System.Drawing.Size(380, 22);
			this.lciOutput.TextSize = new System.Drawing.Size(0, 0);
			this.lciOutput.TextVisible = false;
			// 
			// lciSnapshotDirectory
			// 
			this.lciSnapshotDirectory.Control = this.txtSnapshotDirectory;
			this.lciSnapshotDirectory.Location = new System.Drawing.Point(0, 68);
			this.lciSnapshotDirectory.Name = "lciSnapshotDirectory";
			this.lciSnapshotDirectory.Size = new System.Drawing.Size(380, 24);
			this.lciSnapshotDirectory.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
			this.lciSnapshotDirectory.Text = "Snapshot directory:";
			this.lciSnapshotDirectory.TextSize = new System.Drawing.Size(95, 13);
			// 
			// lciTheme
			// 
			this.lciTheme.Control = this.lblTheme;
			this.lciTheme.Location = new System.Drawing.Point(0, 92);
			this.lciTheme.Name = "lciTheme";
			this.lciTheme.Size = new System.Drawing.Size(380, 27);
			this.lciTheme.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
			this.lciTheme.TextSize = new System.Drawing.Size(0, 0);
			this.lciTheme.TextVisible = false;
			// 
			// lciDark
			// 
			this.lciDark.Control = this.rbDark;
			this.lciDark.Location = new System.Drawing.Point(0, 119);
			this.lciDark.Name = "lciDark";
			this.lciDark.Size = new System.Drawing.Size(70, 24);
			this.lciDark.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
			this.lciDark.TextSize = new System.Drawing.Size(0, 0);
			this.lciDark.TextVisible = false;
			// 
			// lciLight
			// 
			this.lciLight.Control = this.rbLight;
			this.lciLight.Location = new System.Drawing.Point(70, 119);
			this.lciLight.Name = "lciLight";
			this.lciLight.Size = new System.Drawing.Size(310, 24);
			this.lciLight.TextSize = new System.Drawing.Size(0, 0);
			this.lciLight.TextVisible = false;
			// 
			// lciSound
			// 
			this.lciSound.Control = this.lblSound;
			this.lciSound.Location = new System.Drawing.Point(0, 143);
			this.lciSound.Name = "lciSound";
			this.lciSound.Size = new System.Drawing.Size(380, 27);
			this.lciSound.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
			this.lciSound.TextSize = new System.Drawing.Size(0, 0);
			this.lciSound.TextVisible = false;
			// 
			// lciPlaySound
			// 
			this.lciPlaySound.Control = this.chxPlaySound;
			this.lciPlaySound.Location = new System.Drawing.Point(0, 170);
			this.lciPlaySound.Name = "lciPlaySound";
			this.lciPlaySound.Size = new System.Drawing.Size(380, 24);
			this.lciPlaySound.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
			this.lciPlaySound.TextSize = new System.Drawing.Size(0, 0);
			this.lciPlaySound.TextVisible = false;
			// 
			// emptySpaceItem
			// 
			this.emptySpaceItem.AllowHotTrack = false;
			this.emptySpaceItem.Location = new System.Drawing.Point(0, 194);
			this.emptySpaceItem.Name = "emptySpaceItem";
			this.emptySpaceItem.Size = new System.Drawing.Size(380, 86);
			this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
			// 
			// GeneralTab
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.Controls.Add(this.layoutControl);
			this.Name = "GeneralTab";
			this.Size = new System.Drawing.Size(400, 300);
			((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
			this.layoutControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.txtSnapshotDirectory.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbDark.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rbLight.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chxPlaySound.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciOutput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSnapshotDirectory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciTheme)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciDark)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciLight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciSound)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciPlaySound)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciInput)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chxShortInput.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lciShortInput)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraEditors.LabelControl lblInput;
		private DevExpress.XtraEditors.CheckEdit chxShortInput;
		private DevExpress.XtraEditors.LabelControl lblOutput;
        private DevExpress.XtraEditors.ButtonEdit txtSnapshotDirectory;
        private DevExpress.XtraEditors.LabelControl lblTheme;
        private DevExpress.XtraEditors.CheckEdit rbDark;
        private DevExpress.XtraEditors.CheckEdit rbLight;
        private DevExpress.XtraEditors.LabelControl lblSound;
        private DevExpress.XtraEditors.CheckEdit chxPlaySound;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraLayout.LayoutControlItem lciInput;
		private DevExpress.XtraLayout.LayoutControlItem lciShortInput;
		private DevExpress.XtraLayout.LayoutControlItem lciOutput;
        private DevExpress.XtraLayout.LayoutControlItem lciSnapshotDirectory;
        private DevExpress.XtraLayout.LayoutControlItem lciTheme;
        private DevExpress.XtraLayout.LayoutControlItem lciDark;
        private DevExpress.XtraLayout.LayoutControlItem lciLight;
        private DevExpress.XtraLayout.LayoutControlItem lciSound;        
        private DevExpress.XtraLayout.LayoutControlItem lciPlaySound;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
	}
}

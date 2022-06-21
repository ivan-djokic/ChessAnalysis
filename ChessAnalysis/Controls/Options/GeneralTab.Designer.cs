﻿namespace ChessAnalysis.Controls
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralTab));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblOutput = new DevExpress.XtraEditors.LabelControl();
            this.txtSnapshotDirectory = new DevExpress.XtraEditors.ButtonEdit();
            this.lblTheme = new DevExpress.XtraEditors.LabelControl();
            this.rbDark = new DevExpress.XtraEditors.CheckEdit();
            this.rbLight = new DevExpress.XtraEditors.CheckEdit();
            this.lblSound = new DevExpress.XtraEditors.LabelControl();
            this.chxPlaySound = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciOutput = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSnapshotDirectory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTheme = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDark = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLight = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSound = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPlaySound = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtOptionsDirectory = new DevExpress.XtraEditors.ButtonEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSnapshotDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbDark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbLight.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxPlaySound.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSnapshotDirectory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTheme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlaySound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsDirectory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtOptionsDirectory);
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
            // lblOutput
            // 
            this.lblOutput.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOutput.Appearance.Options.UseFont = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 12);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(45, 18);
            this.lblOutput.StyleController = this.layoutControl;
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Output";
            // 
            // txtSnapshotDirectory
            // 
            this.txtSnapshotDirectory.EditValue = "C:\\Users\\User\\Documents\\Chess Analysis\\Snapshots";
            this.txtSnapshotDirectory.Location = new System.Drawing.Point(139, 34);
            this.txtSnapshotDirectory.Name = "txtSnapshotDirectory";
            editorButtonImageOptions2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions2.SvgImage")));
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(12, 12);
            this.txtSnapshotDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtSnapshotDirectory.Size = new System.Drawing.Size(249, 20);
            this.txtSnapshotDirectory.StyleController = this.layoutControl;
            this.txtSnapshotDirectory.TabIndex = 2;
            this.txtSnapshotDirectory.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSnapshotDirectory_ButtonClick);
            // 
            // lblTheme
            // 
            this.lblTheme.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTheme.Appearance.Options.UseFont = true;
            this.lblTheme.Location = new System.Drawing.Point(12, 87);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(47, 18);
            this.lblTheme.StyleController = this.layoutControl;
            this.lblTheme.TabIndex = 3;
            this.lblTheme.Text = "Theme";
            // 
            // rbDark
            // 
            this.rbDark.EditValue = true;
            this.rbDark.Location = new System.Drawing.Point(32, 109);
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
            this.rbLight.Location = new System.Drawing.Point(82, 109);
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
            this.lblSound.Location = new System.Drawing.Point(12, 138);
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(40, 18);
            this.lblSound.StyleController = this.layoutControl;
            this.lblSound.TabIndex = 9;
            this.lblSound.Text = "Sound";
            // 
            // chxPlaySound
            // 
            this.chxPlaySound.EditValue = true;
            this.chxPlaySound.Location = new System.Drawing.Point(32, 160);
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
            this.lciOutput,
            this.lciSnapshotDirectory,
            this.lciTheme,
            this.lciDark,
            this.lciLight,
            this.lciSound,
            this.lciPlaySound,
            this.emptySpaceItem,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(400, 300);
            this.Root.TextVisible = false;
            // 
            // lciOutput
            // 
            this.lciOutput.Control = this.lblOutput;
            this.lciOutput.Location = new System.Drawing.Point(0, 0);
            this.lciOutput.Name = "lciOutput";
            this.lciOutput.Size = new System.Drawing.Size(380, 22);
            this.lciOutput.TextSize = new System.Drawing.Size(0, 0);
            this.lciOutput.TextVisible = false;
            // 
            // lciSnapshotDirectory
            // 
            this.lciSnapshotDirectory.Control = this.txtSnapshotDirectory;
            this.lciSnapshotDirectory.Location = new System.Drawing.Point(0, 22);
            this.lciSnapshotDirectory.Name = "lciSnapshotDirectory";
            this.lciSnapshotDirectory.Size = new System.Drawing.Size(380, 24);
            this.lciSnapshotDirectory.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciSnapshotDirectory.Text = "Snapshot directory:";
            this.lciSnapshotDirectory.TextSize = new System.Drawing.Size(95, 13);
            // 
            // lciTheme
            // 
            this.lciTheme.Control = this.lblTheme;
            this.lciTheme.Location = new System.Drawing.Point(0, 70);
            this.lciTheme.Name = "lciTheme";
            this.lciTheme.Size = new System.Drawing.Size(380, 27);
            this.lciTheme.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.lciTheme.TextSize = new System.Drawing.Size(0, 0);
            this.lciTheme.TextVisible = false;
            // 
            // lciDark
            // 
            this.lciDark.Control = this.rbDark;
            this.lciDark.Location = new System.Drawing.Point(0, 97);
            this.lciDark.Name = "lciDark";
            this.lciDark.Size = new System.Drawing.Size(70, 24);
            this.lciDark.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciDark.TextSize = new System.Drawing.Size(0, 0);
            this.lciDark.TextVisible = false;
            // 
            // lciLight
            // 
            this.lciLight.Control = this.rbLight;
            this.lciLight.Location = new System.Drawing.Point(70, 97);
            this.lciLight.Name = "lciLight";
            this.lciLight.Size = new System.Drawing.Size(310, 24);
            this.lciLight.TextSize = new System.Drawing.Size(0, 0);
            this.lciLight.TextVisible = false;
            // 
            // lciSound
            // 
            this.lciSound.Control = this.lblSound;
            this.lciSound.Location = new System.Drawing.Point(0, 121);
            this.lciSound.Name = "lciSound";
            this.lciSound.Size = new System.Drawing.Size(380, 27);
            this.lciSound.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 0);
            this.lciSound.TextSize = new System.Drawing.Size(0, 0);
            this.lciSound.TextVisible = false;
            // 
            // lciPlaySound
            // 
            this.lciPlaySound.Control = this.chxPlaySound;
            this.lciPlaySound.Location = new System.Drawing.Point(0, 148);
            this.lciPlaySound.Name = "lciPlaySound";
            this.lciPlaySound.Size = new System.Drawing.Size(380, 24);
            this.lciPlaySound.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciPlaySound.TextSize = new System.Drawing.Size(0, 0);
            this.lciPlaySound.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 172);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(380, 108);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSnapshotDirectory;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 22);
            this.layoutControlItem1.Name = "lciSnapshotDirectory";
            this.layoutControlItem1.Size = new System.Drawing.Size(380, 24);
            this.layoutControlItem1.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.layoutControlItem1.Text = "Snapshot directory:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(95, 13);
            // 
            // txtOptionsDirectory
            // 
            this.txtOptionsDirectory.EditValue = "C:\\Users\\User\\AppData\\Local\\Chess Analysis";
            this.txtOptionsDirectory.Location = new System.Drawing.Point(139, 58);
            this.txtOptionsDirectory.Name = "txtOptionsDirectory";
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(12, 12);
            this.txtOptionsDirectory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtOptionsDirectory.Size = new System.Drawing.Size(249, 20);
            this.txtOptionsDirectory.StyleController = this.layoutControl;
            this.txtOptionsDirectory.TabIndex = 11;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtOptionsDirectory;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(380, 24);
            this.layoutControlItem2.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.layoutControlItem2.Text = "Options directory:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(95, 13);
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
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOptionsDirectory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblOutput;
        private DevExpress.XtraEditors.ButtonEdit txtSnapshotDirectory;
        private DevExpress.XtraEditors.LabelControl lblTheme;
        private DevExpress.XtraEditors.CheckEdit rbDark;
        private DevExpress.XtraEditors.CheckEdit rbLight;
        private DevExpress.XtraEditors.LabelControl lblSound;
        private DevExpress.XtraEditors.CheckEdit chxPlaySound;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciOutput;
        private DevExpress.XtraLayout.LayoutControlItem lciSnapshotDirectory;
        private DevExpress.XtraLayout.LayoutControlItem lciTheme;
        private DevExpress.XtraLayout.LayoutControlItem lciDark;
        private DevExpress.XtraLayout.LayoutControlItem lciLight;
        private DevExpress.XtraLayout.LayoutControlItem lciSound;        
        private DevExpress.XtraLayout.LayoutControlItem lciPlaySound;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit txtOptionsDirectory;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}

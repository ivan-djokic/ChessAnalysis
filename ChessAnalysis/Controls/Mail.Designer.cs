namespace ChessAnalysis.Controls
{
    partial class Mail
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.txtAttachments = new DevExpress.XtraEditors.ButtonEdit();
            this.txtReceiver = new DevExpress.XtraEditors.TextEdit();
            this.txtContent = new DevExpress.XtraEditors.MemoEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciReceiver = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAttachments = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAttachments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtAttachments);
            this.layoutControl.Controls.Add(this.txtReceiver);
            this.layoutControl.Controls.Add(this.txtContent);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(678, 151);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // txtAttachments
            // 
            this.txtAttachments.EditValue = "";
            this.txtAttachments.Location = new System.Drawing.Point(89, 128);
            this.txtAttachments.Name = "txtAttachments";
            this.txtAttachments.Properties.AllowFocused = false;
            editorButtonImageOptions1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("editorButtonImageOptions1.SvgImage")));
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(13, 13);
            this.txtAttachments.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.txtAttachments.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.txtAttachments.Size = new System.Drawing.Size(587, 21);
            this.txtAttachments.StyleController = this.layoutControl;
            this.txtAttachments.TabIndex = 3;
            this.txtAttachments.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtAttachments_ButtonClick);
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(89, 2);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(587, 20);
            this.txtReceiver.StyleController = this.layoutControl;
            this.txtReceiver.TabIndex = 5;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(89, 26);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.Size = new System.Drawing.Size(587, 98);
            this.txtContent.StyleController = this.layoutControl;
            this.txtContent.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReceiver,
            this.lciContent,
            this.lciAttachments});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(678, 151);
            this.Root.TextVisible = false;
            // 
            // lciReceiver
            // 
            this.lciReceiver.Control = this.txtReceiver;
            this.lciReceiver.Location = new System.Drawing.Point(0, 0);
            this.lciReceiver.Name = "lciReceiver";
            this.lciReceiver.Size = new System.Drawing.Size(678, 24);
            this.lciReceiver.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciReceiver.Text = "Receiver:";
            this.lciReceiver.TextSize = new System.Drawing.Size(65, 13);
            // 
            // lciContent
            // 
            this.lciContent.Control = this.txtContent;
            this.lciContent.Location = new System.Drawing.Point(0, 24);
            this.lciContent.Name = "lciContent";
            this.lciContent.Size = new System.Drawing.Size(678, 102);
            this.lciContent.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciContent.Text = "Content:";
            this.lciContent.TextSize = new System.Drawing.Size(65, 13);
            // 
            // lciAttachments
            // 
            this.lciAttachments.Control = this.txtAttachments;
            this.lciAttachments.Location = new System.Drawing.Point(0, 126);
            this.lciAttachments.Name = "lciAttachments";
            this.lciAttachments.Size = new System.Drawing.Size(678, 25);
            this.lciAttachments.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciAttachments.Text = "Attachments:";
            this.lciAttachments.TextSize = new System.Drawing.Size(65, 13);
            // 
            // lciAdd
            // 
            this.lciAdd.Location = new System.Drawing.Point(0, 304);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(484, 26);
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "Mail";
            this.Size = new System.Drawing.Size(678, 151);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtAttachments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit txtReceiver;
        private DevExpress.XtraEditors.MemoEdit txtContent;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciReceiver;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
        private DevExpress.XtraEditors.ButtonEdit txtAttachments;
        private DevExpress.XtraLayout.LayoutControlItem lciAttachments;
    }
}

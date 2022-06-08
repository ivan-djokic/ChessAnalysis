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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtReceiver = new DevExpress.XtraEditors.TextEdit();
            this.lciReceiver = new DevExpress.XtraLayout.LayoutControlItem();
            this.txtContent = new DevExpress.XtraEditors.MemoEdit();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtContent);
            this.layoutControl.Controls.Add(this.txtReceiver);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(678, 122);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciReceiver,
            this.lciContent});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(678, 122);
            this.Root.TextVisible = false;
            // 
            // lciAdd
            // 
            this.lciAdd.Location = new System.Drawing.Point(0, 304);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(484, 26);
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(70, 2);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(606, 20);
            this.txtReceiver.StyleController = this.layoutControl;
            this.txtReceiver.TabIndex = 5;
            // 
            // lciReceiver
            // 
            this.lciReceiver.Control = this.txtReceiver;
            this.lciReceiver.Location = new System.Drawing.Point(0, 0);
            this.lciReceiver.Name = "lciReceiver";
            this.lciReceiver.Size = new System.Drawing.Size(678, 24);
            this.lciReceiver.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciReceiver.Text = "Receiver:";
            this.lciReceiver.TextSize = new System.Drawing.Size(46, 13);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(70, 26);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.Size = new System.Drawing.Size(606, 94);
            this.txtContent.StyleController = this.layoutControl;
            this.txtContent.TabIndex = 6;
            // 
            // lciContent
            // 
            this.lciContent.Control = this.txtContent;
            this.lciContent.Location = new System.Drawing.Point(0, 24);
            this.lciContent.Name = "lciContent";
            this.lciContent.Size = new System.Drawing.Size(678, 98);
            this.lciContent.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciContent.Text = "Content:";
            this.lciContent.TextSize = new System.Drawing.Size(46, 13);
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "Mail";
            this.Size = new System.Drawing.Size(678, 122);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
        private DevExpress.XtraEditors.TextEdit txtReceiver;
        private DevExpress.XtraLayout.LayoutControlItem lciReceiver;
        private DevExpress.XtraEditors.MemoEdit txtContent;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
    }
}

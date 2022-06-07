namespace ChessAnalysis.Forms
{
    partial class MailForm
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
            this.txtContent = new DevExpress.XtraEditors.MemoEdit();
            this.txtReceiver = new DevExpress.XtraEditors.TextEdit();
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSend = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciReceiver = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciContent = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.txtContent);
            this.layoutControl.Controls.Add(this.txtReceiver);
            this.layoutControl.Controls.Add(this.btnSend);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(698, 168);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(101, 36);
            this.txtContent.Name = "txtContent";
            this.txtContent.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContent.Size = new System.Drawing.Size(585, 94);
            this.txtContent.StyleController = this.layoutControl;
            this.txtContent.TabIndex = 5;
            // 
            // txtReceiver
            // 
            this.txtReceiver.Location = new System.Drawing.Point(101, 12);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.Size = new System.Drawing.Size(585, 20);
            this.txtReceiver.StyleController = this.layoutControl;
            this.txtReceiver.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.AllowFocus = false;
            this.btnSend.Location = new System.Drawing.Point(610, 134);
            this.btnSend.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnSend.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(76, 22);
            this.btnSend.StyleController = this.layoutControl;
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSend,
            this.lciReceiver,
            this.lciContent});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(698, 168);
            this.Root.TextVisible = false;
            // 
            // lciSend
            // 
            this.lciSend.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciSend.Control = this.btnSend;
            this.lciSend.Location = new System.Drawing.Point(0, 122);
            this.lciSend.Name = "lciSend";
            this.lciSend.Size = new System.Drawing.Size(678, 26);
            this.lciSend.TextSize = new System.Drawing.Size(0, 0);
            this.lciSend.TextVisible = false;
            // 
            // lciReceiver
            // 
            this.lciReceiver.Control = this.txtReceiver;
            this.lciReceiver.Location = new System.Drawing.Point(0, 0);
            this.lciReceiver.Name = "lciReceiver";
            this.lciReceiver.Size = new System.Drawing.Size(678, 24);
            this.lciReceiver.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciReceiver.Text = "Receiver mail:";
            this.lciReceiver.TextSize = new System.Drawing.Size(67, 13);
            // 
            // lciContent
            // 
            this.lciContent.Control = this.txtContent;
            this.lciContent.Location = new System.Drawing.Point(0, 24);
            this.lciContent.Name = "lciContent";
            this.lciContent.Size = new System.Drawing.Size(678, 98);
            this.lciContent.Spacing = new DevExpress.XtraLayout.Utils.Padding(10, 0, 0, 0);
            this.lciContent.Text = "Content:";
            this.lciContent.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciContent.TextSize = new System.Drawing.Size(67, 13);
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(698, 168);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MailForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Send mail";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiver.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReceiver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciSend;
        private DevExpress.XtraEditors.MemoEdit txtContent;
        private DevExpress.XtraEditors.TextEdit txtReceiver;
        private DevExpress.XtraLayout.LayoutControlItem lciReceiver;
        private DevExpress.XtraLayout.LayoutControlItem lciContent;
    }
}
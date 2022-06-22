namespace ChessAnalysis.Controls
{
    partial class MailTab
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
            this.lblMail = new DevExpress.XtraEditors.LabelControl();
            this.txtSmtpClient = new DevExpress.XtraEditors.TextEdit();
            this.txtMail = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMailConfiguration = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSmtpClient = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciMail = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtpClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMailConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSmtpClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblMail);
            this.layoutControl.Controls.Add(this.txtSmtpClient);
            this.layoutControl.Controls.Add(this.txtMail);
            this.layoutControl.Controls.Add(this.txtPassword);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(400, 300);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lblMail
            // 
            this.lblMail.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMail.Appearance.Options.UseFont = true;
            this.lblMail.Location = new System.Drawing.Point(12, 12);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(111, 18);
            this.lblMail.StyleController = this.layoutControl;
            this.lblMail.TabIndex = 1;
            this.lblMail.Text = "Mail configuration";
            // 
            // txtSmtpClient
            // 
            this.txtSmtpClient.EditValue = "smtp.gmail.com";
            this.txtSmtpClient.Location = new System.Drawing.Point(131, 34);
            this.txtSmtpClient.Name = "txtSmtpClient";
            this.txtSmtpClient.Size = new System.Drawing.Size(257, 20);
            this.txtSmtpClient.StyleController = this.layoutControl;
            this.txtSmtpClient.TabIndex = 2;
            // 
            // txtMail
            // 
            this.txtMail.EditValue = "chess.analysis.bot@gmail.com";
            this.txtMail.Location = new System.Drawing.Point(131, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(257, 20);
            this.txtMail.StyleController = this.layoutControl;
            this.txtMail.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.EditValue = "analysis64#";
            this.txtPassword.Location = new System.Drawing.Point(131, 82);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(257, 20);
            this.txtPassword.StyleController = this.layoutControl;
            this.txtPassword.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMailConfiguration,
            this.lciSmtpClient,
            this.lciMail,
            this.lciPassword,
            this.emptySpaceItem});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(400, 300);
            this.Root.TextVisible = false;
            // 
            // lciMailConfiguration
            // 
            this.lciMailConfiguration.Control = this.lblMail;
            this.lciMailConfiguration.Location = new System.Drawing.Point(0, 0);
            this.lciMailConfiguration.Name = "lciMailConfiguration";
            this.lciMailConfiguration.Size = new System.Drawing.Size(380, 22);
            this.lciMailConfiguration.TextSize = new System.Drawing.Size(0, 0);
            this.lciMailConfiguration.TextVisible = false;
            // 
            // lciSmtpClient
            // 
            this.lciSmtpClient.Control = this.txtSmtpClient;
            this.lciSmtpClient.Location = new System.Drawing.Point(0, 22);
            this.lciSmtpClient.Name = "lciSmtpClient";
            this.lciSmtpClient.Size = new System.Drawing.Size(380, 24);
            this.lciSmtpClient.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciSmtpClient.Text = "SMTP client:";
            this.lciSmtpClient.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciMail
            // 
            this.lciMail.Control = this.txtMail;
            this.lciMail.Location = new System.Drawing.Point(0, 46);
            this.lciMail.Name = "lciMail";
            this.lciMail.Size = new System.Drawing.Size(380, 24);
            this.lciMail.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciMail.Text = "Sender mail:";
            this.lciMail.TextSize = new System.Drawing.Size(87, 13);
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.txtPassword;
            this.lciPassword.Location = new System.Drawing.Point(0, 70);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.Size = new System.Drawing.Size(380, 24);
            this.lciPassword.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciPassword.Text = "Sender password:";
            this.lciPassword.TextSize = new System.Drawing.Size(87, 13);
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 94);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(380, 186);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // MailTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "MailTab";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSmtpClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMailConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSmtpClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblMail;
        private DevExpress.XtraEditors.TextEdit txtSmtpClient;
        private DevExpress.XtraEditors.TextEdit txtMail;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciMailConfiguration;
        private DevExpress.XtraLayout.LayoutControlItem lciMail;
        private DevExpress.XtraLayout.LayoutControlItem lciSmtpClient;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
    }
}

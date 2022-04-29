namespace ChessAnalysis.Controls
{
    partial class Board
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
            this.lblDefense = new DevExpress.XtraEditors.LabelControl();
            this.lblOpening = new DevExpress.XtraEditors.LabelControl();
            this.imageBoard = new ChessAnalysis.Controls.CenteredImageBox();
            this.lblTimestamp = new DevExpress.XtraEditors.LabelControl();
            this.lblPlayers = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPlayers = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTimestamp = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciImage = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOpening = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDefense = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTimestamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefense)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblDefense);
            this.layoutControl.Controls.Add(this.lblOpening);
            this.layoutControl.Controls.Add(this.imageBoard);
            this.layoutControl.Controls.Add(this.lblTimestamp);
            this.layoutControl.Controls.Add(this.lblPlayers);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(450, 519);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lblDefense
            // 
            this.lblDefense.Appearance.Options.UseTextOptions = true;
            this.lblDefense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblDefense.Location = new System.Drawing.Point(227, 56);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(211, 16);
            this.lblDefense.StyleController = this.layoutControl;
            this.lblDefense.TabIndex = 7;
            this.lblDefense.Text = "Defense type";
            // 
            // lblOpening
            // 
            this.lblOpening.Location = new System.Drawing.Point(12, 56);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(211, 16);
            this.lblOpening.StyleController = this.layoutControl;
            this.lblOpening.TabIndex = 6;
            this.lblOpening.Text = "Opening type";
            // 
            // imageBoard
            // 
            this.imageBoard.Image = null;
            this.imageBoard.Location = new System.Drawing.Point(12, 76);
            this.imageBoard.Name = "imageBoard";
            this.imageBoard.Size = new System.Drawing.Size(426, 431);
            this.imageBoard.TabIndex = 8;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(191, 34);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(67, 13);
            this.lblTimestamp.StyleController = this.layoutControl;
            this.lblTimestamp.TabIndex = 5;
            this.lblTimestamp.Text = "Date and time";
            // 
            // lblPlayers
            // 
            this.lblPlayers.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayers.Appearance.Options.UseFont = true;
            this.lblPlayers.Location = new System.Drawing.Point(138, 12);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(173, 18);
            this.lblPlayers.StyleController = this.layoutControl;
            this.lblPlayers.TabIndex = 4;
            this.lblPlayers.Text = "White player - Black player";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPlayers,
            this.lciTimestamp,
            this.lciImage,
            this.lciOpening,
            this.lciDefense});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(450, 519);
            this.Root.TextVisible = false;
            // 
            // lciPlayers
            // 
            this.lciPlayers.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciPlayers.Control = this.lblPlayers;
            this.lciPlayers.Location = new System.Drawing.Point(0, 0);
            this.lciPlayers.Name = "lciPlayers";
            this.lciPlayers.Size = new System.Drawing.Size(430, 22);
            this.lciPlayers.TextSize = new System.Drawing.Size(0, 0);
            this.lciPlayers.TextVisible = false;
            // 
            // lciTimestamp
            // 
            this.lciTimestamp.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciTimestamp.Control = this.lblTimestamp;
            this.lciTimestamp.Location = new System.Drawing.Point(0, 22);
            this.lciTimestamp.Name = "lciTimestamp";
            this.lciTimestamp.Size = new System.Drawing.Size(430, 22);
            this.lciTimestamp.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.lciTimestamp.TextSize = new System.Drawing.Size(0, 0);
            this.lciTimestamp.TextVisible = false;
            // 
            // lciImage
            // 
            this.lciImage.Control = this.imageBoard;
            this.lciImage.Location = new System.Drawing.Point(0, 64);
            this.lciImage.Name = "lciImage";
            this.lciImage.Size = new System.Drawing.Size(430, 435);
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextVisible = false;
            // 
            // lciOpening
            // 
            this.lciOpening.Control = this.lblOpening;
            this.lciOpening.Location = new System.Drawing.Point(0, 44);
            this.lciOpening.MinSize = new System.Drawing.Size(69, 20);
            this.lciOpening.Name = "lciOpening";
            this.lciOpening.Size = new System.Drawing.Size(215, 20);
            this.lciOpening.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOpening.TextSize = new System.Drawing.Size(0, 0);
            this.lciOpening.TextVisible = false;
            // 
            // lciDefense
            // 
            this.lciDefense.Control = this.lblDefense;
            this.lciDefense.Location = new System.Drawing.Point(215, 44);
            this.lciDefense.MinSize = new System.Drawing.Size(69, 20);
            this.lciDefense.Name = "lciDefense";
            this.lciDefense.Size = new System.Drawing.Size(215, 20);
            this.lciDefense.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDefense.TextSize = new System.Drawing.Size(0, 0);
            this.lciDefense.TextVisible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(450, 519);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTimestamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefense)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblPlayers;
        private DevExpress.XtraLayout.LayoutControlItem lciPlayers;
        private DevExpress.XtraEditors.LabelControl lblTimestamp;
        private DevExpress.XtraLayout.LayoutControlItem lciTimestamp;
        private DevExpress.XtraEditors.LabelControl lblOpening;
        private DevExpress.XtraLayout.LayoutControlItem lciOpening;
        private DevExpress.XtraEditors.LabelControl lblDefense;
        private DevExpress.XtraLayout.LayoutControlItem lciDefense;
        private CenteredImageBox imageBoard;
        private DevExpress.XtraLayout.LayoutControlItem lciImage;
    }
}

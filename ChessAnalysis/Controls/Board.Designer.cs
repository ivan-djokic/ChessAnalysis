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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lblDefense = new DevExpress.XtraEditors.LabelControl();
            this.lblOpening = new DevExpress.XtraEditors.LabelControl();
            this.imageBoard = new ChessAnalysis.Controls.CenteredImageBox();
            this.lblTimestamp = new DevExpress.XtraEditors.LabelControl();
            this.lblPlayers = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPlayers = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTimestamp = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTimestamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lblDefense);
            this.layoutControl1.Controls.Add(this.lblOpening);
            this.layoutControl1.Controls.Add(this.imageBoard);
            this.layoutControl1.Controls.Add(this.lblTimestamp);
            this.layoutControl1.Controls.Add(this.lblPlayers);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(450, 519);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lblDefense
            // 
            this.lblDefense.Appearance.Options.UseTextOptions = true;
            this.lblDefense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblDefense.Location = new System.Drawing.Point(227, 61);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(211, 16);
            this.lblDefense.StyleController = this.layoutControl1;
            this.lblDefense.TabIndex = 7;
            this.lblDefense.Text = "Defense type";
            // 
            // lblOpening
            // 
            this.lblOpening.Location = new System.Drawing.Point(12, 61);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(211, 16);
            this.lblOpening.StyleController = this.layoutControl1;
            this.lblOpening.TabIndex = 6;
            this.lblOpening.Text = "Opening type";
            // 
            // imageBoard
            // 
            this.imageBoard.Image = null;
            this.imageBoard.Location = new System.Drawing.Point(12, 81);
            this.imageBoard.Name = "imageBoard";
            this.imageBoard.Size = new System.Drawing.Size(426, 426);
            this.imageBoard.TabIndex = 8;
            // 
            // lblTimestamp
            // 
            this.lblTimestamp.Location = new System.Drawing.Point(191, 39);
            this.lblTimestamp.Name = "lblTimestamp";
            this.lblTimestamp.Size = new System.Drawing.Size(67, 13);
            this.lblTimestamp.StyleController = this.layoutControl1;
            this.lblTimestamp.TabIndex = 5;
            this.lblTimestamp.Text = "Date and time";
            // 
            // lblPlayers
            // 
            this.lblPlayers.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayers.Appearance.Options.UseFont = true;
            this.lblPlayers.Location = new System.Drawing.Point(113, 12);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(224, 23);
            this.lblPlayers.StyleController = this.layoutControl1;
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
            this.layoutControlItem5,
            this.layoutControlItem2,
            this.layoutControlItem3});
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
            this.lciPlayers.Size = new System.Drawing.Size(430, 27);
            this.lciPlayers.TextSize = new System.Drawing.Size(0, 0);
            this.lciPlayers.TextVisible = false;
            // 
            // lciTimestamp
            // 
            this.lciTimestamp.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciTimestamp.Control = this.lblTimestamp;
            this.lciTimestamp.Location = new System.Drawing.Point(0, 27);
            this.lciTimestamp.Name = "lciTimestamp";
            this.lciTimestamp.Size = new System.Drawing.Size(430, 22);
            this.lciTimestamp.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.lciTimestamp.TextSize = new System.Drawing.Size(0, 0);
            this.lciTimestamp.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.imageBoard;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 69);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(430, 430);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.lblOpening;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(69, 20);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(215, 20);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lblDefense;
            this.layoutControlItem3.Location = new System.Drawing.Point(215, 49);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(69, 20);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(215, 20);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(450, 519);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTimestamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl lblTimestamp;
        private DevExpress.XtraEditors.LabelControl lblPlayers;
        private DevExpress.XtraLayout.LayoutControlItem lciPlayers;
        private DevExpress.XtraLayout.LayoutControlItem lciTimestamp;
        private CenteredImageBox imageBoard;
        private DevExpress.XtraEditors.LabelControl lblDefense;
        private DevExpress.XtraEditors.LabelControl lblOpening;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

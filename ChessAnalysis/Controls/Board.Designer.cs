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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblPlayers = new DevExpress.XtraEditors.LabelControl();
            this.lblResult = new DevExpress.XtraEditors.LabelControl();
            this.lblOpening = new DevExpress.XtraEditors.LabelControl();
            this.lblDefense = new DevExpress.XtraEditors.LabelControl();
            this.btnFlip = new DevExpress.XtraEditors.SimpleButton();
            this.imageBoard = new ChessAnalysis.Controls.CenteredImageBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPlayers = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResult = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciOpening = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDefense = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFlip = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciImage = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpening)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblPlayers);
            this.layoutControl.Controls.Add(this.lblResult);
            this.layoutControl.Controls.Add(this.lblOpening);
            this.layoutControl.Controls.Add(this.lblDefense);
            this.layoutControl.Controls.Add(this.btnFlip);
            this.layoutControl.Controls.Add(this.imageBoard);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(427, 519);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lblPlayers
            // 
            this.lblPlayers.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPlayers.Appearance.Options.UseFont = true;
            this.lblPlayers.Location = new System.Drawing.Point(127, 12);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(173, 18);
            this.lblPlayers.StyleController = this.layoutControl;
            this.lblPlayers.TabIndex = 1;
            this.lblPlayers.Text = "White player - Black player";
            // 
            // lblResult
            // 
            this.lblResult.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Appearance.Options.UseFont = true;
            this.lblResult.Location = new System.Drawing.Point(195, 34);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 13);
            this.lblResult.StyleController = this.layoutControl;
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result";
            // 
            // lblOpening
            // 
            this.lblOpening.Location = new System.Drawing.Point(12, 56);
            this.lblOpening.Name = "lblOpening";
            this.lblOpening.Size = new System.Drawing.Size(199, 18);
            this.lblOpening.StyleController = this.layoutControl;
            this.lblOpening.TabIndex = 3;
            this.lblOpening.Text = "Opening type";
            // 
            // lblDefense
            // 
            this.lblDefense.Appearance.Options.UseTextOptions = true;
            this.lblDefense.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblDefense.Location = new System.Drawing.Point(215, 56);
            this.lblDefense.MaximumSize = new System.Drawing.Size(0, 18);
            this.lblDefense.MinimumSize = new System.Drawing.Size(0, 18);
            this.lblDefense.Name = "lblDefense";
            this.lblDefense.Size = new System.Drawing.Size(200, 18);
            this.lblDefense.StyleController = this.layoutControl;
            this.lblDefense.TabIndex = 4;
            this.lblDefense.Text = "Defense type";
            // 
            // btnFlip
            // 
            this.btnFlip.AllowFocus = false;
            this.btnFlip.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnFlip.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFlip.ImageOptions.SvgImage")));
            this.btnFlip.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnFlip.Location = new System.Drawing.Point(393, 78);
            this.btnFlip.MaximumSize = new System.Drawing.Size(18, 18);
            this.btnFlip.MinimumSize = new System.Drawing.Size(18, 18);
            this.btnFlip.Name = "btnFlip";
            this.btnFlip.Size = new System.Drawing.Size(18, 18);
            this.btnFlip.StyleController = this.layoutControl;
            toolTipItem1.Text = "Flip board";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnFlip.SuperTip = superToolTip1;
            this.btnFlip.TabIndex = 5;
            this.btnFlip.Click += new System.EventHandler(this.btnFlip_Click);
            // 
            // imageBoard
            // 
            this.imageBoard.Image = null;
            this.imageBoard.Location = new System.Drawing.Point(12, 104);
            this.imageBoard.Name = "imageBoard";
            this.imageBoard.Size = new System.Drawing.Size(403, 403);
            this.imageBoard.TabIndex = 6;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPlayers,
            this.lciResult,
            this.lciOpening,
            this.lciDefense,
            this.lciFlip,
            this.lciImage});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(427, 519);
            this.Root.TextVisible = false;
            // 
            // lciPlayers
            // 
            this.lciPlayers.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciPlayers.Control = this.lblPlayers;
            this.lciPlayers.Location = new System.Drawing.Point(0, 0);
            this.lciPlayers.Name = "lciPlayers";
            this.lciPlayers.Size = new System.Drawing.Size(407, 22);
            this.lciPlayers.TextSize = new System.Drawing.Size(0, 0);
            this.lciPlayers.TextVisible = false;
            // 
            // lciResult
            // 
            this.lciResult.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lciResult.Control = this.lblResult;
            this.lciResult.Location = new System.Drawing.Point(0, 22);
            this.lciResult.Name = "lciResult";
            this.lciResult.Size = new System.Drawing.Size(407, 22);
            this.lciResult.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 5);
            this.lciResult.TextSize = new System.Drawing.Size(0, 0);
            this.lciResult.TextVisible = false;
            // 
            // lciOpening
            // 
            this.lciOpening.Control = this.lblOpening;
            this.lciOpening.Location = new System.Drawing.Point(0, 44);
            this.lciOpening.MaxSize = new System.Drawing.Size(0, 22);
            this.lciOpening.MinSize = new System.Drawing.Size(1, 22);
            this.lciOpening.Name = "lciOpening";
            this.lciOpening.Size = new System.Drawing.Size(203, 22);
            this.lciOpening.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciOpening.TextSize = new System.Drawing.Size(0, 0);
            this.lciOpening.TextVisible = false;
            // 
            // lciDefense
            // 
            this.lciDefense.Control = this.lblDefense;
            this.lciDefense.Location = new System.Drawing.Point(203, 44);
            this.lciDefense.MaxSize = new System.Drawing.Size(0, 22);
            this.lciDefense.MinSize = new System.Drawing.Size(1, 22);
            this.lciDefense.Name = "lciDefense";
            this.lciDefense.Size = new System.Drawing.Size(204, 22);
            this.lciDefense.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDefense.TextSize = new System.Drawing.Size(0, 0);
            this.lciDefense.TextVisible = false;
            // 
            // lciFlip
            // 
            this.lciFlip.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciFlip.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.lciFlip.Control = this.btnFlip;
            this.lciFlip.Location = new System.Drawing.Point(0, 66);
            this.lciFlip.Name = "lciFlip";
            this.lciFlip.Size = new System.Drawing.Size(407, 26);
            this.lciFlip.TextSize = new System.Drawing.Size(0, 0);
            this.lciFlip.TextVisible = false;
            // 
            // lciImage
            // 
            this.lciImage.Control = this.imageBoard;
            this.lciImage.Location = new System.Drawing.Point(0, 92);
            this.lciImage.Name = "lciImage";
            this.lciImage.Size = new System.Drawing.Size(407, 407);
            this.lciImage.TextSize = new System.Drawing.Size(0, 0);
            this.lciImage.TextVisible = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "Board";
            this.Size = new System.Drawing.Size(427, 519);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOpening)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDefense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblPlayers;
        private DevExpress.XtraEditors.LabelControl lblResult;
        private DevExpress.XtraEditors.LabelControl lblOpening;
        private DevExpress.XtraEditors.LabelControl lblDefense;
        private DevExpress.XtraEditors.SimpleButton btnFlip;
        private CenteredImageBox imageBoard;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciPlayers;
        private DevExpress.XtraLayout.LayoutControlItem lciResult;
        private DevExpress.XtraLayout.LayoutControlItem lciOpening;
        private DevExpress.XtraLayout.LayoutControlItem lciDefense;
        private DevExpress.XtraLayout.LayoutControlItem lciFlip;
        private DevExpress.XtraLayout.LayoutControlItem lciImage;
    }
}

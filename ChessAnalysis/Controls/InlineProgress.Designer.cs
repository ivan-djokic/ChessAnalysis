namespace ChessAnalysis.Controls
{
	partial class InlineProgress
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
            this.progressBar = new DevExpress.XtraEditors.ProgressBarControl();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciProgress = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStop = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStop)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.progressBar);
            this.layoutControl.Controls.Add(this.btnStop);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(424, 68);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Properties.ShowTitle = true;
            this.progressBar.ShowProgressInTaskBar = true;
            this.progressBar.Size = new System.Drawing.Size(400, 18);
            this.progressBar.StyleController = this.layoutControl;
            this.progressBar.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.AllowFocus = false;
            this.btnStop.Location = new System.Drawing.Point(336, 34);
            this.btnStop.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnStop.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(76, 22);
            this.btnStop.StyleController = this.layoutControl;
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciProgress,
            this.lciStop});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(424, 68);
            this.Root.TextVisible = false;
            // 
            // lciProgress
            // 
            this.lciProgress.Control = this.progressBar;
            this.lciProgress.Location = new System.Drawing.Point(0, 0);
            this.lciProgress.Name = "lciProgress";
            this.lciProgress.Size = new System.Drawing.Size(404, 22);
            this.lciProgress.TextSize = new System.Drawing.Size(0, 0);
            this.lciProgress.TextVisible = false;
            // 
            // lciStop
            // 
            this.lciStop.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciStop.Control = this.btnStop;
            this.lciStop.Location = new System.Drawing.Point(0, 22);
            this.lciStop.Name = "lciStop";
            this.lciStop.Size = new System.Drawing.Size(404, 26);
            this.lciStop.TextSize = new System.Drawing.Size(0, 0);
            this.lciStop.TextVisible = false;
            // 
            // InlineProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutControl);
            this.Name = "InlineProgress";
            this.Size = new System.Drawing.Size(424, 68);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStop)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraLayout.LayoutControl layoutControl;
		private DevExpress.XtraLayout.LayoutControlGroup Root;
		private DevExpress.XtraEditors.SimpleButton btnStop;
		private DevExpress.XtraLayout.LayoutControlItem lciStop;
		private DevExpress.XtraEditors.ProgressBarControl progressBar;
		private DevExpress.XtraLayout.LayoutControlItem lciProgress;
	}
}

﻿namespace ChessAnalysis.Forms
{
    partial class AddFromFileForm
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
            this.panel = new ChessAnalysis.Controls.MainPanel();
            this.btnLoadFile = new DevExpress.XtraEditors.SimpleButton();
            this.btnImport = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciPanel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLoadFile = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciImport = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoadFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImport)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.panel);
            this.layoutControl.Controls.Add(this.btnLoadFile);
            this.layoutControl.Controls.Add(this.btnImport);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(1080, 573);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(12, 12);
            this.panel.Name = "panel";
            this.panel.ShowOnlyMainControls = true;
            this.panel.Size = new System.Drawing.Size(1056, 523);
            this.panel.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.AllowFocus = false;
            this.btnLoadFile.Location = new System.Drawing.Point(12, 539);
            this.btnLoadFile.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnLoadFile.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(76, 22);
            this.btnLoadFile.StyleController = this.layoutControl;
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "Load file";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // btnImport
            // 
            this.btnImport.AllowFocus = false;
            this.btnImport.DialogResult = DialogResult.OK;
            this.btnImport.Location = new System.Drawing.Point(992, 539);
            this.btnImport.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnImport.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(76, 22);
            this.btnImport.StyleController = this.layoutControl;
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciPanel,
            this.lciLoadFile,
            this.lciImport});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1080, 573);
            this.Root.TextVisible = false;
            // 
            // lciPanel
            // 
            this.lciPanel.Control = this.panel;
            this.lciPanel.Location = new System.Drawing.Point(0, 0);
            this.lciPanel.Name = "lciPanel";
            this.lciPanel.Size = new System.Drawing.Size(1060, 527);
            this.lciPanel.TextSize = new System.Drawing.Size(0, 0);
            this.lciPanel.TextVisible = false;
            // 
            // lciLoadFile
            // 
            this.lciLoadFile.Control = this.btnLoadFile;
            this.lciLoadFile.Location = new System.Drawing.Point(0, 527);
            this.lciLoadFile.Name = "lciLoadFile";
            this.lciLoadFile.Size = new System.Drawing.Size(80, 26);
            this.lciLoadFile.TextSize = new System.Drawing.Size(0, 0);
            this.lciLoadFile.TextVisible = false;
            // 
            // lciImport
            // 
            this.lciImport.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciImport.Control = this.btnImport;
            this.lciImport.Location = new System.Drawing.Point(80, 527);
            this.lciImport.Name = "lciImport";
            this.lciImport.Size = new System.Drawing.Size(980, 26);
            this.lciImport.TextSize = new System.Drawing.Size(0, 0);
            this.lciImport.TextVisible = false;
            // 
            // AddFromFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1080, 573);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddFromFileForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add data from file";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLoadFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private Controls.MainPanel panel;
        private DevExpress.XtraEditors.SimpleButton btnLoadFile;
        private DevExpress.XtraEditors.SimpleButton btnImport;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciPanel;
        private DevExpress.XtraLayout.LayoutControlItem lciLoadFile;
        private DevExpress.XtraLayout.LayoutControlItem lciImport;
    }
}
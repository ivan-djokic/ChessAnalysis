namespace ChessAnalysis.Forms
{
    partial class AddForm
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
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.dataInput = new ChessAnalysis.Controls.DataInput();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciInput = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAdd = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnAdd);
            this.layoutControl.Controls.Add(this.dataInput);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(748, 87);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl1";
            // 
            // btnAdd
            // 
            this.btnAdd.AllowFocus = false;
            this.btnAdd.Location = new System.Drawing.Point(660, 53);
            this.btnAdd.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnAdd.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 22);
            this.btnAdd.StyleController = this.layoutControl;
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dataInput
            // 
            this.dataInput.Input = "";
            this.dataInput.Location = new System.Drawing.Point(12, 12);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(724, 37);
            this.dataInput.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciInput,
            this.lciAdd});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(748, 87);
            this.Root.TextVisible = false;
            // 
            // lciInput
            // 
            this.lciInput.Control = this.dataInput;
            this.lciInput.Location = new System.Drawing.Point(0, 0);
            this.lciInput.Name = "lciInput";
            this.lciInput.Size = new System.Drawing.Size(728, 41);
            this.lciInput.TextSize = new System.Drawing.Size(0, 0);
            this.lciInput.TextVisible = false;
            // 
            // lciAdd
            // 
            this.lciAdd.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciAdd.Control = this.btnAdd;
            this.lciAdd.Location = new System.Drawing.Point(0, 41);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(728, 26);
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(748, 87);
            this.Controls.Add(this.layoutControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add data from clipboard";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Controls.DataInput dataInput;
        private DevExpress.XtraLayout.LayoutControlItem lciInput;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraLayout.LayoutControlItem lciAdd;
    }
}
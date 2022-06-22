namespace ChessAnalysis.Forms
{
    partial class EditForm
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.dataInput = new ChessAnalysis.Controls.DataInput();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciInput = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.dataInput);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(746, 78);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnEdit
            // 
            this.btnEdit.AllowFocus = false;
            this.btnEdit.Location = new System.Drawing.Point(658, 44);
            this.btnEdit.MaximumSize = new System.Drawing.Size(76, 22);
            this.btnEdit.MinimumSize = new System.Drawing.Size(76, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(76, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dataInput
            // 
            this.dataInput.Input = "";
            this.dataInput.Location = new System.Drawing.Point(12, 12);
            this.dataInput.Name = "dataInput";
            this.dataInput.Size = new System.Drawing.Size(722, 28);
            this.dataInput.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciInput,
            this.lciEdit});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(746, 78);
            this.Root.TextVisible = false;
            // 
            // lciInput
            // 
            this.lciInput.Control = this.dataInput;
            this.lciInput.Location = new System.Drawing.Point(0, 0);
            this.lciInput.Name = "lciInput";
            this.lciInput.Size = new System.Drawing.Size(726, 32);
            this.lciInput.TextSize = new System.Drawing.Size(0, 0);
            this.lciInput.TextVisible = false;
            // 
            // lciEdit
            // 
            this.lciEdit.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciEdit.Control = this.btnEdit;
            this.lciEdit.Location = new System.Drawing.Point(0, 32);
            this.lciEdit.Name = "lciEdit";
            this.lciEdit.Size = new System.Drawing.Size(726, 26);
            this.lciEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciEdit.TextVisible = false;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(746, 78);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit data";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private Controls.DataInput dataInput;
        private DevExpress.XtraLayout.LayoutControlItem lciInput;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
    }
}
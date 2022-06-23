namespace ChessAnalysis.Controls
{
    partial class ErrorGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorGrid));
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.lblMessage = new DevExpress.XtraEditors.LabelControl();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLine = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMessage = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciYes = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNo = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNo)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblMessage);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Controls.Add(this.btnYes);
            this.layoutControl.Controls.Add(this.btnNo);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(474, 224);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lblMessage.Location = new System.Drawing.Point(43, 2);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(429, 30);
            this.lblMessage.StyleController = this.layoutControl;
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Some data are not correctly generated.\r\nDo you want to continue?";
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(2, 36);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(470, 160);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMessage,
            this.colLine});
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupCount = 1;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "({0})")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowFilter = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colMessage, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMessage
            // 
            this.colMessage.Caption = "Error";
            this.colMessage.FieldName = "Message";
            this.colMessage.Name = "colMessage";
            this.colMessage.OptionsColumn.AllowEdit = false;
            this.colMessage.OptionsColumn.AllowFocus = false;
            this.colMessage.Visible = true;
            this.colMessage.VisibleIndex = 0;
            // 
            // colLine
            // 
            this.colLine.Caption = "Line";
            this.colLine.FieldName = "Line";
            this.colLine.Name = "colLine";
            this.colLine.OptionsColumn.AllowEdit = false;
            this.colLine.OptionsColumn.AllowFocus = false;
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 0;
            // 
            // btnYes
            // 
            this.btnYes.AllowFocus = false;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(159, 200);
            this.btnYes.MaximumSize = new System.Drawing.Size(76, 0);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(76, 22);
            this.btnYes.StyleController = this.layoutControl;
            this.btnYes.TabIndex = 1;
            this.btnYes.Text = "Yes";
            // 
            // btnNo
            // 
            this.btnNo.AllowFocus = false;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnNo.Location = new System.Drawing.Point(239, 200);
            this.btnNo.MaximumSize = new System.Drawing.Size(76, 0);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(76, 22);
            this.btnNo.StyleController = this.layoutControl;
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMessage,
            this.lciGrid,
            this.lciYes,
            this.lciNo});
            this.Root.Name = "Root";
            this.Root.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.Root.Size = new System.Drawing.Size(474, 224);
            // 
            // lciMessage
            // 
            this.lciMessage.Control = this.lblMessage;
            this.lciMessage.ImageOptions.ImageToTextDistance = 8;
            this.lciMessage.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lciMessage.ImageOptions.SvgImage")));
            this.lciMessage.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.lciMessage.Location = new System.Drawing.Point(0, 0);
            this.lciMessage.Name = "lciMessage";
            this.lciMessage.Size = new System.Drawing.Size(474, 34);
            this.lciMessage.Text = " ";
            this.lciMessage.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.lciMessage.TextSize = new System.Drawing.Size(41, 30);
            this.lciMessage.TextToControlDistance = 0;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gridControl;
            this.lciGrid.Location = new System.Drawing.Point(0, 34);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(474, 164);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // lciYes
            // 
            this.lciYes.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lciYes.Control = this.btnYes;
            this.lciYes.Location = new System.Drawing.Point(0, 198);
            this.lciYes.Name = "lciYes";
            this.lciYes.Size = new System.Drawing.Size(237, 26);
            this.lciYes.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciYes.TextSize = new System.Drawing.Size(0, 0);
            this.lciYes.TextVisible = false;
            // 
            // lciNo
            // 
            this.lciNo.Control = this.btnNo;
            this.lciNo.Location = new System.Drawing.Point(237, 198);
            this.lciNo.Name = "lciNo";
            this.lciNo.Size = new System.Drawing.Size(237, 26);
            this.lciNo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.lciNo.TextSize = new System.Drawing.Size(0, 0);
            this.lciNo.TextVisible = false;
            // 
            // ErrorGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "ErrorGrid";
            this.Size = new System.Drawing.Size(474, 224);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblMessage;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colLine;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciMessage;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
        private DevExpress.XtraLayout.LayoutControlItem lciYes;
        private DevExpress.XtraLayout.LayoutControlItem lciNo;
    }
}

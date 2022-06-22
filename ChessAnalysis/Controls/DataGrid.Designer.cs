namespace ChessAnalysis.Controls
{
    partial class DataGrid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataGrid));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip3 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem3 = new DevExpress.Utils.ToolTipItem();
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.btnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new ChessAnalysis.Controls.MultiSelectGridView();
            this.colRound = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNextPlayer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCastlingWhite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCastlingBlack = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEnPassant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHalfMoves = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBestMove = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colResult = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpening = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDefense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlayers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRestore = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEdit = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciGrid = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.btnRestore);
            this.layoutControl.Controls.Add(this.btnEdit);
            this.layoutControl.Controls.Add(this.btnRemove);
            this.layoutControl.Controls.Add(this.gridControl);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(742, 519);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // btnRestore
            // 
            this.btnRestore.AllowFocus = false;
            this.btnRestore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRestore.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRestore.ImageOptions.SvgImage")));
            this.btnRestore.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnRestore.Location = new System.Drawing.Point(12, 12);
            this.btnRestore.MaximumSize = new System.Drawing.Size(18, 18);
            this.btnRestore.MinimumSize = new System.Drawing.Size(18, 18);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(18, 18);
            this.btnRestore.StyleController = this.layoutControl;
            toolTipItem1.Text = "Reload grid";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnRestore.SuperTip = superToolTip1;
            this.btnRestore.TabIndex = 1;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AllowFocus = false;
            this.btnEdit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnEdit.Location = new System.Drawing.Point(38, 12);
            this.btnEdit.MaximumSize = new System.Drawing.Size(18, 18);
            this.btnEdit.MinimumSize = new System.Drawing.Size(18, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(18, 18);
            this.btnEdit.StyleController = this.layoutControl;
            toolTipItem2.Text = "Edit focused item";
            superToolTip2.Items.Add(toolTipItem2);
            this.btnEdit.SuperTip = superToolTip2;
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AllowFocus = false;
            this.btnRemove.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnRemove.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRemove.ImageOptions.SvgImage")));
            this.btnRemove.ImageOptions.SvgImageSize = new System.Drawing.Size(16, 16);
            this.btnRemove.Location = new System.Drawing.Point(64, 12);
            this.btnRemove.MaximumSize = new System.Drawing.Size(18, 18);
            this.btnRemove.MinimumSize = new System.Drawing.Size(18, 18);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(18, 18);
            this.btnRemove.StyleController = this.layoutControl;
            toolTipItem3.Text = "Remove selection";
            superToolTip3.Items.Add(toolTipItem3);
            this.btnRemove.SuperTip = superToolTip3;
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 38);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(718, 469);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.AutoFillColumn = colPlayers;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRound,
            this.colNextPlayer,
            this.colCastlingWhite,
            this.colCastlingBlack,
            this.colEnPassant,
            this.colHalfMoves,
            this.colBestMove,
            this.colResult,
            this.colOpening,
            this.colDefense,
            this.colPlayers});
            this.gridView.DetailHeight = 303;
            this.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView.GridControl = this.gridControl;
            this.gridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "", null, "({0})")});
            this.gridView.Name = "gridView";
            this.gridView.OptionsFilter.AllowMRUFilterList = false;
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView_FocusedRowChanged);
            // 
            // colRound
            // 
            this.colRound.Caption = "Round";
            this.colRound.FieldName = "Position.Round";
            this.colRound.Name = "colRound";
            this.colRound.OptionsColumn.AllowEdit = false;
            this.colRound.OptionsColumn.AllowFocus = false;
            this.colRound.Visible = true;
            this.colRound.VisibleIndex = 0;
            this.colRound.Width = 62;
            // 
            // colNextPlayer
            // 
            this.colNextPlayer.Caption = "Next player";
            this.colNextPlayer.FieldName = "Position.NextPlayer";
            this.colNextPlayer.Name = "colNextPlayer";
            this.colNextPlayer.OptionsColumn.AllowEdit = false;
            this.colNextPlayer.OptionsColumn.AllowFocus = false;
            this.colNextPlayer.Visible = true;
            this.colNextPlayer.VisibleIndex = 1;
            this.colNextPlayer.Width = 87;
            // 
            // colCastlingWhite
            // 
            this.colCastlingWhite.Caption = "White castling";
            this.colCastlingWhite.FieldName = "Position.CastlingWhite";
            this.colCastlingWhite.Name = "colCastlingWhite";
            this.colCastlingWhite.OptionsColumn.AllowEdit = false;
            this.colCastlingWhite.OptionsColumn.AllowFocus = false;
            this.colCastlingWhite.Visible = true;
            this.colCastlingWhite.VisibleIndex = 2;
            this.colCastlingWhite.Width = 98;
            // 
            // colCastlingBlack
            // 
            this.colCastlingBlack.Caption = "Black castling";
            this.colCastlingBlack.FieldName = "Position.CastlingBlack";
            this.colCastlingBlack.Name = "colCastlingBlack";
            this.colCastlingBlack.OptionsColumn.AllowEdit = false;
            this.colCastlingBlack.OptionsColumn.AllowFocus = false;
            this.colCastlingBlack.Visible = true;
            this.colCastlingBlack.VisibleIndex = 3;
            this.colCastlingBlack.Width = 94;
            // 
            // colEnPassant
            // 
            this.colEnPassant.Caption = "En passant";
            this.colEnPassant.FieldName = "Position.EnPassant";
            this.colEnPassant.Name = "colEnPassant";
            this.colEnPassant.OptionsColumn.AllowEdit = false;
            this.colEnPassant.OptionsColumn.AllowFocus = false;
            this.colEnPassant.Visible = true;
            this.colEnPassant.VisibleIndex = 4;
            this.colEnPassant.Width = 84;
            // 
            // colHalfMoves
            // 
            this.colHalfMoves.Caption = "Half moves";
            this.colHalfMoves.FieldName = "Position.HalfMoves";
            this.colHalfMoves.Name = "colHalfMoves";
            this.colHalfMoves.OptionsColumn.AllowEdit = false;
            this.colHalfMoves.OptionsColumn.AllowFocus = false;
            this.colHalfMoves.Visible = true;
            this.colHalfMoves.VisibleIndex = 5;
            this.colHalfMoves.Width = 84;
            // 
            // colBestMove
            // 
            this.colBestMove.Caption = "Best move";
            this.colBestMove.FieldName = "Position.BestMove";
            this.colBestMove.Name = "colBestMove";
            this.colBestMove.OptionsColumn.AllowEdit = false;
            this.colBestMove.OptionsColumn.AllowFocus = false;
            this.colBestMove.Visible = true;
            this.colBestMove.VisibleIndex = 6;
            this.colBestMove.Width = 81;
            // 
            // colResult
            // 
            this.colResult.Caption = "Result";
            this.colResult.FieldName = "Comment.Result";
            this.colResult.Name = "colResult";
            this.colResult.OptionsColumn.AllowEdit = false;
            this.colResult.OptionsColumn.AllowFocus = false;
            this.colResult.Visible = true;
            this.colResult.VisibleIndex = 7;
            this.colResult.Width = 60;
            // 
            // colOpening
            // 
            this.colOpening.Caption = "Opening";
            this.colOpening.FieldName = "Comment.Opening";
            this.colOpening.Name = "colOpening";
            this.colOpening.OptionsColumn.AllowEdit = false;
            this.colOpening.OptionsColumn.AllowFocus = false;
            this.colOpening.Visible = true;
            this.colOpening.VisibleIndex = 8;
            this.colOpening.Width = 130;
            // 
            // colDefense
            // 
            this.colDefense.Caption = "Defense";
            this.colDefense.FieldName = "Comment.Defense";
            this.colDefense.Name = "colDefense";
            this.colDefense.OptionsColumn.AllowEdit = false;
            this.colDefense.OptionsColumn.AllowFocus = false;
            this.colDefense.Visible = true;
            this.colDefense.VisibleIndex = 9;
            this.colDefense.Width = 130;
            // 
            // colPlayers
            // 
            this.colPlayers.Caption = "Players";
            this.colPlayers.FieldName = "Comment.Players";
            this.colPlayers.Name = "colPlayers";
            this.colPlayers.OptionsColumn.AllowEdit = false;
            this.colPlayers.OptionsColumn.AllowFocus = false;
            this.colPlayers.Visible = true;
            this.colPlayers.VisibleIndex = 10;
            this.colPlayers.Width = 160;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRestore,
            this.lciEdit,
            this.lciRemove,
            this.lciGrid});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(742, 519);
            this.Root.TextVisible = false;
            // 
            // lciRestore
            // 
            this.lciRestore.Control = this.btnRestore;
            this.lciRestore.Location = new System.Drawing.Point(0, 0);
            this.lciRestore.Name = "lciRestore";
            this.lciRestore.Size = new System.Drawing.Size(26, 26);
            this.lciRestore.TextSize = new System.Drawing.Size(0, 0);
            this.lciRestore.TextVisible = false;
            // 
            // lciEdit
            // 
            this.lciEdit.Control = this.btnEdit;
            this.lciEdit.Location = new System.Drawing.Point(26, 0);
            this.lciEdit.Name = "lciEdit";
            this.lciEdit.Size = new System.Drawing.Size(26, 26);
            this.lciEdit.TextSize = new System.Drawing.Size(0, 0);
            this.lciEdit.TextVisible = false;
            // 
            // lciRemove
            // 
            this.lciRemove.Control = this.btnRemove;
            this.lciRemove.Location = new System.Drawing.Point(52, 0);
            this.lciRemove.Name = "lciRemove";
            this.lciRemove.Size = new System.Drawing.Size(670, 26);
            this.lciRemove.TextSize = new System.Drawing.Size(0, 0);
            this.lciRemove.TextVisible = false;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gridControl;
            this.lciGrid.Location = new System.Drawing.Point(0, 26);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(722, 473);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // DataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "DataGrid";
            this.Size = new System.Drawing.Size(742, 519);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRestore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.SimpleButton btnRestore;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraGrid.GridControl gridControl;
        private MultiSelectGridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colRound;
        private DevExpress.XtraGrid.Columns.GridColumn colNextPlayer;
        private DevExpress.XtraGrid.Columns.GridColumn colCastlingWhite;
        private DevExpress.XtraGrid.Columns.GridColumn colCastlingBlack;
        private DevExpress.XtraGrid.Columns.GridColumn colEnPassant;
        private DevExpress.XtraGrid.Columns.GridColumn colHalfMoves;
        private DevExpress.XtraGrid.Columns.GridColumn colBestMove;
        private DevExpress.XtraGrid.Columns.GridColumn colResult;
        private DevExpress.XtraGrid.Columns.GridColumn colOpening;
        private DevExpress.XtraGrid.Columns.GridColumn colDefense;
        private DevExpress.XtraGrid.Columns.GridColumn colPlayers;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciRestore;
        private DevExpress.XtraLayout.LayoutControlItem lciEdit;
        private DevExpress.XtraLayout.LayoutControlItem lciRemove;
        private DevExpress.XtraLayout.LayoutControlItem lciGrid;
    }
}

namespace ChessAnalysis.Controls
{
    partial class BoardTab
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
            this.lblBoard = new DevExpress.XtraEditors.LabelControl();
            this.colorFill = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorEmpty = new DevExpress.XtraEditors.ColorPickEdit();
            this.chxCoords = new DevExpress.XtraEditors.CheckEdit();
            this.chxBestMove = new DevExpress.XtraEditors.CheckEdit();
            this.chxFlipBoard = new DevExpress.XtraEditors.CheckEdit();
            this.lblPieces = new DevExpress.XtraEditors.LabelControl();
            this.rbClassic = new DevExpress.XtraEditors.CheckEdit();
            this.rbNeo = new DevExpress.XtraEditors.CheckEdit();
            this.rbWood = new DevExpress.XtraEditors.CheckEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciBoard = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFillColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmptyColor = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCoords = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBestMove = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFlipBoard = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPieces = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClassic = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciNeo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciWood = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorFill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEmpty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxCoords.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxBestMove.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxFlipBoard.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbClassic.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNeo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWood.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFillColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmptyColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBestMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlipBoard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPieces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClassic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNeo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.lblBoard);
            this.layoutControl.Controls.Add(this.colorFill);
            this.layoutControl.Controls.Add(this.colorEmpty);
            this.layoutControl.Controls.Add(this.chxCoords);
            this.layoutControl.Controls.Add(this.chxBestMove);
            this.layoutControl.Controls.Add(this.chxFlipBoard);
            this.layoutControl.Controls.Add(this.lblPieces);
            this.layoutControl.Controls.Add(this.rbClassic);
            this.layoutControl.Controls.Add(this.rbNeo);
            this.layoutControl.Controls.Add(this.rbWood);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(400, 300);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // lblBoard
            // 
            this.lblBoard.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBoard.Appearance.Options.UseFont = true;
            this.lblBoard.Location = new System.Drawing.Point(12, 12);
            this.lblBoard.Name = "lblBoard";
            this.lblBoard.Size = new System.Drawing.Size(38, 18);
            this.lblBoard.StyleController = this.layoutControl;
            this.lblBoard.TabIndex = 1;
            this.lblBoard.Text = "Board";
            // 
            // colorFill
            // 
            this.colorFill.EditValue = System.Drawing.Color.SkyBlue;
            this.colorFill.Location = new System.Drawing.Point(127, 34);
            this.colorFill.Name = "colorFill";
            this.colorFill.Properties.AllowFocused = false;
            this.colorFill.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorFill.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorFill.Size = new System.Drawing.Size(261, 20);
            this.colorFill.StyleController = this.layoutControl;
            this.colorFill.TabIndex = 2;
            // 
            // colorEmpty
            // 
            this.colorEmpty.EditValue = System.Drawing.Color.LightGray;
            this.colorEmpty.Location = new System.Drawing.Point(127, 58);
            this.colorEmpty.Name = "colorEmpty";
            this.colorEmpty.Properties.AllowFocused = false;
            this.colorEmpty.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorEmpty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorEmpty.Size = new System.Drawing.Size(261, 20);
            this.colorEmpty.StyleController = this.layoutControl;
            this.colorEmpty.TabIndex = 3;
            // 
            // chxCoords
            // 
            this.chxCoords.EditValue = true;
            this.chxCoords.Location = new System.Drawing.Point(32, 82);
            this.chxCoords.Name = "chxCoords";
            this.chxCoords.Properties.AllowFocused = false;
            this.chxCoords.Properties.Caption = "Show coordinates";
            this.chxCoords.Size = new System.Drawing.Size(356, 20);
            this.chxCoords.StyleController = this.layoutControl;
            this.chxCoords.TabIndex = 4;
            // 
            // chxBestMove
            // 
            this.chxBestMove.EditValue = true;
            this.chxBestMove.Location = new System.Drawing.Point(32, 106);
            this.chxBestMove.Name = "chxBestMove";
            this.chxBestMove.Properties.AllowFocused = false;
            this.chxBestMove.Properties.Caption = "Mark if best move is played";
            this.chxBestMove.Size = new System.Drawing.Size(356, 20);
            this.chxBestMove.StyleController = this.layoutControl;
            this.chxBestMove.TabIndex = 5;
            // 
            // chxFlipBoard
            // 
            this.chxFlipBoard.EditValue = true;
            this.chxFlipBoard.Location = new System.Drawing.Point(32, 130);
            this.chxFlipBoard.Name = "chxFlipBoard";
            this.chxFlipBoard.Properties.AllowFocused = false;
            this.chxFlipBoard.Properties.Caption = "Automatically flip board depending on player";
            this.chxFlipBoard.Size = new System.Drawing.Size(356, 20);
            this.chxFlipBoard.StyleController = this.layoutControl;
            this.chxFlipBoard.TabIndex = 6;
            // 
            // lblPieces
            // 
            this.lblPieces.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPieces.Appearance.Options.UseFont = true;
            this.lblPieces.Location = new System.Drawing.Point(12, 160);
            this.lblPieces.Name = "lblPieces";
            this.lblPieces.Size = new System.Drawing.Size(40, 18);
            this.lblPieces.StyleController = this.layoutControl;
            this.lblPieces.TabIndex = 7;
            this.lblPieces.Text = "Pieces";
            // 
            // rbClassic
            // 
            this.rbClassic.EditValue = true;
            this.rbClassic.Location = new System.Drawing.Point(32, 182);
            this.rbClassic.Name = "rbClassic";
            this.rbClassic.Properties.AllowFocused = false;
            this.rbClassic.Properties.Caption = "Classic";
            this.rbClassic.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.rbClassic.Properties.RadioGroupIndex = 0;
            this.rbClassic.Size = new System.Drawing.Size(56, 20);
            this.rbClassic.StyleController = this.layoutControl;
            this.rbClassic.TabIndex = 8;
            // 
            // rbNeo
            // 
            this.rbNeo.Location = new System.Drawing.Point(92, 182);
            this.rbNeo.Name = "rbNeo";
            this.rbNeo.Properties.AllowFocused = false;
            this.rbNeo.Properties.Caption = "Neo";
            this.rbNeo.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.rbNeo.Properties.RadioGroupIndex = 0;
            this.rbNeo.Size = new System.Drawing.Size(43, 20);
            this.rbNeo.StyleController = this.layoutControl;
            this.rbNeo.TabIndex = 9;
            this.rbNeo.TabStop = false;
            // 
            // rbWood
            // 
            this.rbWood.Location = new System.Drawing.Point(139, 182);
            this.rbWood.Name = "rbWood";
            this.rbWood.Properties.AllowFocused = false;
            this.rbWood.Properties.Caption = "Wood";
            this.rbWood.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.Radio;
            this.rbWood.Properties.RadioGroupIndex = 0;
            this.rbWood.Size = new System.Drawing.Size(249, 20);
            this.rbWood.StyleController = this.layoutControl;
            this.rbWood.TabIndex = 10;
            this.rbWood.TabStop = false;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBoard,
            this.lciFillColor,
            this.lciEmptyColor,
            this.lciCoords,
            this.lciBestMove,
            this.lciFlipBoard,
            this.lciPieces,
            this.lciClassic,
            this.lciNeo,
            this.lciWood,
            this.emptySpaceItem});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(400, 300);
            this.Root.TextVisible = false;
            // 
            // lciBoard
            // 
            this.lciBoard.Control = this.lblBoard;
            this.lciBoard.Location = new System.Drawing.Point(0, 0);
            this.lciBoard.Name = "lciBoard";
            this.lciBoard.Size = new System.Drawing.Size(380, 22);
            this.lciBoard.TextSize = new System.Drawing.Size(0, 0);
            this.lciBoard.TextVisible = false;
            // 
            // lciFillColor
            // 
            this.lciFillColor.Control = this.colorFill;
            this.lciFillColor.Location = new System.Drawing.Point(0, 22);
            this.lciFillColor.Name = "lciFillColor";
            this.lciFillColor.Size = new System.Drawing.Size(380, 24);
            this.lciFillColor.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciFillColor.Text = "Fill field color:";
            this.lciFillColor.TextSize = new System.Drawing.Size(83, 13);
            // 
            // lciEmptyColor
            // 
            this.lciEmptyColor.Control = this.colorEmpty;
            this.lciEmptyColor.Location = new System.Drawing.Point(0, 46);
            this.lciEmptyColor.Name = "lciEmptyColor";
            this.lciEmptyColor.Size = new System.Drawing.Size(380, 24);
            this.lciEmptyColor.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciEmptyColor.Text = "Empty field color:";
            this.lciEmptyColor.TextSize = new System.Drawing.Size(83, 13);
            // 
            // lciCoords
            // 
            this.lciCoords.Control = this.chxCoords;
            this.lciCoords.Location = new System.Drawing.Point(0, 70);
            this.lciCoords.Name = "lciCoords";
            this.lciCoords.Size = new System.Drawing.Size(380, 24);
            this.lciCoords.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciCoords.TextSize = new System.Drawing.Size(0, 0);
            this.lciCoords.TextVisible = false;
            // 
            // lciBestMove
            // 
            this.lciBestMove.Control = this.chxBestMove;
            this.lciBestMove.Location = new System.Drawing.Point(0, 94);
            this.lciBestMove.Name = "lciBestMove";
            this.lciBestMove.Size = new System.Drawing.Size(380, 24);
            this.lciBestMove.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciBestMove.TextSize = new System.Drawing.Size(0, 0);
            this.lciBestMove.TextVisible = false;
            // 
            // lciFlipBoard
            // 
            this.lciFlipBoard.Control = this.chxFlipBoard;
            this.lciFlipBoard.Location = new System.Drawing.Point(0, 118);
            this.lciFlipBoard.Name = "lciFlipBoard";
            this.lciFlipBoard.Size = new System.Drawing.Size(380, 24);
            this.lciFlipBoard.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciFlipBoard.TextSize = new System.Drawing.Size(0, 0);
            this.lciFlipBoard.TextVisible = false;
            // 
            // lciPieces
            // 
            this.lciPieces.Control = this.lblPieces;
            this.lciPieces.Location = new System.Drawing.Point(0, 142);
            this.lciPieces.Name = "lciPieces";
            this.lciPieces.Size = new System.Drawing.Size(380, 28);
            this.lciPieces.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 6, 0);
            this.lciPieces.TextSize = new System.Drawing.Size(0, 0);
            this.lciPieces.TextVisible = false;
            // 
            // lciClassic
            // 
            this.lciClassic.Control = this.rbClassic;
            this.lciClassic.Location = new System.Drawing.Point(0, 170);
            this.lciClassic.Name = "lciClassic";
            this.lciClassic.Size = new System.Drawing.Size(80, 24);
            this.lciClassic.Spacing = new DevExpress.XtraLayout.Utils.Padding(20, 0, 0, 0);
            this.lciClassic.TextSize = new System.Drawing.Size(0, 0);
            this.lciClassic.TextVisible = false;
            // 
            // lciNeo
            // 
            this.lciNeo.Control = this.rbNeo;
            this.lciNeo.Location = new System.Drawing.Point(80, 170);
            this.lciNeo.Name = "lciNeo";
            this.lciNeo.Size = new System.Drawing.Size(47, 24);
            this.lciNeo.TextSize = new System.Drawing.Size(0, 0);
            this.lciNeo.TextVisible = false;
            // 
            // lciWood
            // 
            this.lciWood.Control = this.rbWood;
            this.lciWood.Location = new System.Drawing.Point(127, 170);
            this.lciWood.Name = "lciWood";
            this.lciWood.Size = new System.Drawing.Size(253, 24);
            this.lciWood.TextSize = new System.Drawing.Size(0, 0);
            this.lciWood.TextVisible = false;
            // 
            // emptySpaceItem
            // 
            this.emptySpaceItem.AllowHotTrack = false;
            this.emptySpaceItem.Location = new System.Drawing.Point(0, 194);
            this.emptySpaceItem.Name = "emptySpaceItem";
            this.emptySpaceItem.Size = new System.Drawing.Size(380, 86);
            this.emptySpaceItem.TextSize = new System.Drawing.Size(0, 0);
            // 
            // BoardTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.layoutControl);
            this.Name = "BoardTab";
            this.Size = new System.Drawing.Size(400, 300);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorFill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorEmpty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxCoords.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxBestMove.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chxFlipBoard.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbClassic.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbNeo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbWood.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFillColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmptyColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCoords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBestMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFlipBoard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPieces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClassic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNeo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciWood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.LabelControl lblBoard;
        private DevExpress.XtraEditors.ColorPickEdit colorFill;
        private DevExpress.XtraEditors.ColorPickEdit colorEmpty;
        private DevExpress.XtraEditors.CheckEdit chxCoords;
        private DevExpress.XtraEditors.CheckEdit chxBestMove;
        private DevExpress.XtraEditors.CheckEdit chxFlipBoard;
        private DevExpress.XtraEditors.LabelControl lblPieces;
        private DevExpress.XtraEditors.CheckEdit rbWood;
        private DevExpress.XtraEditors.CheckEdit rbNeo;
        private DevExpress.XtraEditors.CheckEdit rbClassic;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem lciBoard;
        private DevExpress.XtraLayout.LayoutControlItem lciFillColor;
        private DevExpress.XtraLayout.LayoutControlItem lciEmptyColor;
        private DevExpress.XtraLayout.LayoutControlItem lciCoords;
        private DevExpress.XtraLayout.LayoutControlItem lciBestMove;
        private DevExpress.XtraLayout.LayoutControlItem lciFlipBoard;
        private DevExpress.XtraLayout.LayoutControlItem lciPieces;
        private DevExpress.XtraLayout.LayoutControlItem lciClassic;
        private DevExpress.XtraLayout.LayoutControlItem lciNeo;
        private DevExpress.XtraLayout.LayoutControlItem lciWood;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem;
    }
}

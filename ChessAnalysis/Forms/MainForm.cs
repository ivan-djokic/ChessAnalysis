using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;

namespace ChessAnalysis.Forms
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            Theming.ApplyTheme();

            SetIcons();
            SetToolTips();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            SetIcons();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            board1.Reinitialize(new Game("c0 \"Kasparov - Karpov\" \"22.12.2003 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
            //board2.Initialize(BoardImageCreator.Create("r1q1r3/5kpp/1ppN1p2/p2n4/P7/3P1QP1/5PP1/1R2R1K1"), "Kasparov - Karpov", "22.12.2003 17:31:05", "King's pawn opening", "Sicilian defense");
        }

        private void btnAddFromFile_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnMail_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnOptions_ItemClick(object sender, ItemClickEventArgs e)
        {
            using var optionsForm = new OptionsForm();

            if (optionsForm.ShowDialog() == DialogResult.OK)
            {
                Theming.ApplyTheme();

                board1.Reinitialize(new Game("c0 \"Kasparov - Karpov\" \"22.12.2003 17:31:05\" \"King's pawn opening\" \"Sicilian defense\""),
                    "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
            }
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnSnapshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            board1.Snapshot(this);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // da li treba da se sacuva
            // ovde moze da se suva TEMP proj
        }

        private void SetIcons()
        {
            btnAdd.ImageOptions.LargeImage = Resources.GetIcon("Add");
            btnAddFromFile.ImageOptions.LargeImage = Resources.GetIcon("AddFromFile");
            btnSave.ImageOptions.LargeImage = Resources.GetIcon("Save");
            btnSaveAs.ImageOptions.LargeImage = Resources.GetIcon("SaveAs");
            btnMail.ImageOptions.LargeImage = Resources.GetIcon("Mail");
            btnSnapshot.ImageOptions.LargeImage = Resources.GetIcon("Snapshot");
            btnOptions.ImageOptions.LargeImage = Resources.GetIcon("Options");
        }

        private void SetToolTip(BarItem item, string text)
        {
            using (var toolTip = new ToolTipItem { Text = text })
            {
                var superToolTip = new SuperToolTip();
                superToolTip.Items.Add(toolTip);
                item.SuperTip = superToolTip;
            }
        }

        private void SetToolTips()
        {
            SetToolTip(btnAdd, "Add new position(s) from cliboard");
            SetToolTip(btnAddFromFile, "Add new position(s) from file");
            SetToolTip(btnSave, "Save current positions");
            SetToolTip(btnSaveAs, "Save current positions as");
            SetToolTip(btnMail, "Send position via mail");
            SetToolTip(btnSnapshot, "Take a table snapshot");
            SetToolTip(btnOptions, "Edit application options");

            SetToolTip(lblTotal, "Total number of positions");
        }
    }
}
using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System.Media;

namespace ChessAnalysis.Forms
{
    public partial class MainForm : RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            SetIcons();
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            SetIcons();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            board.InputData = new InputData("rnbqkbnr/pppppppp/8/8/4P3/8/PPPP1PPP/RNBQKBNR b KQkq - 0 1 bm e4; id \"KK03\"; c0 \"Kasparov - Karpov\" \"22.12.2003 17:31:05\" \"King's pawn opening\" \"Sicilian defense\"");
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
            optionsForm.ShowDialog();
        }

        private void btnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnSaveAs_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void btnSnapshot_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (board.Snapshot(this))
            {
                SoundPlay.Snapshot();
            }
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
    }
}
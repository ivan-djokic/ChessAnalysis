using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using System.IO;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        public Board()
        {
            InitializeComponent();
        }

        public void Reinitialize(Game game, string fen)
        {
            lblPlayers.Text = game.Players;
            lblTimestamp.Text = game.Timestamp;
            lblOpening.Text = game.Opening;
            lblDefense.Text = game.Defense;

            imageBoard.Image = BoardImageCreator.Create(fen);
        }

        public void Snapshot(IWin32Window owner)
        {
            using var saveDialog = new XtraSaveFileDialog()
            {
                FileName = "TODO: Shotch this with ID",
                Filter = Constants.SAVE_IMAGE_FILTER,
                InitialDirectory = Options.Instance.DefaultSnapshotDirectory
            };

            if (saveDialog.ShowDialog(owner) != DialogResult.OK)
            {
                return;
            }

            imageBoard.Save(saveDialog.FileName);

            var lastDirectory = Path.GetDirectoryName(saveDialog.FileName);

            if (string.IsNullOrEmpty(lastDirectory))
            {
                return;
            }

            Options.Instance.DefaultSnapshotDirectory = lastDirectory;
            Options.Instance.Save();
        }
    }
}

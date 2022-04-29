using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        private InputData m_inputData;

        public Board()
        {
            InitializeComponent();

            InputData = new(Constants.DEFAULT_INPUT);
            Options.BoardOptionsChanged += DrawImage;
        }

        public InputData InputData 
        { 
            get => m_inputData; 
            set
            {
                m_inputData = value;
                Reinitialize();
            }
        }

        public void Snapshot(IWin32Window owner)
        {
            using var saveDialog = new XtraSaveFileDialog()
            {
                FileName = m_inputData.Id,
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

        private void DrawImage()
        {
            imageBoard.Image = BoardImageCreator.Create(InputData.Position);
        }

        private void Reinitialize()
        {
            lblPlayers.Text = m_inputData.Game.Players;
            lblTimestamp.Text = m_inputData.Game.Timestamp;
            lblOpening.Text = m_inputData.Game.Opening;
            lblDefense.Text = m_inputData.Game.Defense;

            DrawImage();
        }
    }
}

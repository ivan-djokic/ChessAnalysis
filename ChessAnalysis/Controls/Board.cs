using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        private InputData m_inputData;
        private bool? m_isWhiteOriented;

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

        public bool Snapshot(IWin32Window owner)
        {
            using var saveDialog = new XtraSaveFileDialog()
            {
                FileName = m_inputData.Id,
                Filter = Constants.SAVE_IMAGE_FILTER,
                InitialDirectory = Options.Instance.DefaultSnapshotDirectory
            };

            if (saveDialog.ShowDialog(owner) != DialogResult.OK)
            {
                return false;
            }

            imageBoard.Image.Save(saveDialog.FileName);

            var lastDirectory = Path.GetDirectoryName(saveDialog.FileName);

            if (string.IsNullOrEmpty(lastDirectory))
            {
                return false;
            }

            Options.Instance.DefaultSnapshotDirectory = lastDirectory;
            Options.Instance.Save();
            return true;
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            m_isWhiteOriented = !m_isWhiteOriented;
            DrawImage();
        }

        private void DrawImage()
        {
            imageBoard.Image = BoardImageCreator.Create(InputData.Position, ref m_isWhiteOriented);
        }

        private void Reinitialize()
        {
            lblPlayers.Text = m_inputData.Game.Players;
            lblTimestamp.Text = m_inputData.Game.Timestamp;
            lblOpening.Text = m_inputData.Game.Opening;
            lblDefense.Text = m_inputData.Game.Defense;

            m_isWhiteOriented = null;
            DrawImage();
        }
    }
}

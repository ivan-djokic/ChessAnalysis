using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        private Data m_data;
        private bool? m_isWhiteOriented;

        public Board()
        {
            InitializeComponent();

            Data = Parser.Parse(Constants.DEFAULT_INPUT);
            Options.BoardOptionsChanged += DrawImage;
        }

        public Data Data 
        { 
            get => m_data; 
            set
            {
                m_data = value;
                Reinitialize();
            }
        }

        public bool Snapshot(IWin32Window owner)
        {
            using var saveDialog = new XtraSaveFileDialog()
            {
                FileName = m_data.Id,
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
            DrawImage(false);
        }

        private void DrawImage(bool resetOrientation)
        {
            if (resetOrientation)
            {
                m_isWhiteOriented = null;
            }

            imageBoard.Image = BoardImageCreator.Create(m_data.Position, ref m_isWhiteOriented);
        }

        private void Reinitialize()
        {
            lblPlayers.Text = m_data.Comment.Players;
            lblTimestamp.Text = m_data.Comment.Timestamp;
            lblOpening.Text = m_data.Comment.Opening;
            lblDefense.Text = m_data.Comment.Defense;

            DrawImage(true);
        }
    }
}

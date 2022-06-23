using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        private Data m_data;
        private LayoutVisibility m_controlsVisibility;

        public Board()
        {
            InitializeComponent();

            Options.BoardOptionsChanged += DrawImage;
            Reinitialize(Parser.Parse(Constants.DEFAULT_INPUT));
        }

        public bool ShowOnlyBoard
        {
            get => m_controlsVisibility == LayoutVisibility.Never;
            set
            {
                if (ShowOnlyBoard != value)
                {
                    m_controlsVisibility = value ? LayoutVisibility.Never : LayoutVisibility.Always;
                    ChangeControlsVisibility();
                }
            }
        }

        public void Reinitialize(Data data)
        {
            lblPlayers.Text = data.Comment.Players;
            lblResult.Text = data.Comment.Result;
            lblOpening.Text = data.Comment.Opening;
            lblDefense.Text = data.Comment.Defense;

            m_data = data;
            DrawImage();
        }

        public void TakeSnapshot()
        {
            try
            {
                FileHelper.CreateDirIfNotExists(Options.Instance.SnapshotDirectory);
                var fileName = SaveSnapshot(Path.Combine(Options.Instance.SnapshotDirectory, string.Format(Constants.SNAPSHOT_FILE, m_data.Id)));

                Sound.Play(Sounds.Snapshot);
                Notification.Notify?.Invoke(string.Format(Resources.NotifySnapshot, Path.GetFileName(fileName)));
            }
            catch
            {
                ErrorMessage.Show(this, Resources.SnapshotError, MessageBoxButtons.OK);
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            Options.Instance.WhiteOrientedBoard = !Options.Instance.WhiteOrientedBoard;
            Options.Instance.Save();

            Sound.Play(Sounds.Flip);
            DrawImage();
        }

        private void ChangeControlsVisibility()
        {
            lciPlayers.Visibility = m_controlsVisibility;
            lciResult.Visibility = m_controlsVisibility;
            lciOpening.Visibility = m_controlsVisibility;
            lciDefense.Visibility = m_controlsVisibility;
            lciFlip.Visibility = m_controlsVisibility;
        }

        private void DrawImage()
        {
            imageBoard.Image = BoardImage.Create(m_data.Position);
        }

        private string SaveSnapshot(string fileName, int tryCount = 2)
        {
            if (!File.Exists(fileName))
            {
                imageBoard.Image.Save(fileName);
                return fileName;
            }

            return SaveSnapshot(
                Path.Combine(Options.Instance.SnapshotDirectory, string.Format(Constants.SNAPSHOT_FILE_DUPLICATE, m_data.Id, tryCount)), tryCount + 1);
        }
    }
}

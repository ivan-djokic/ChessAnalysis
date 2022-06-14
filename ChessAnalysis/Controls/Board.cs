using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;

namespace ChessAnalysis.Controls
{
    public partial class Board : XtraUserControl
    {
        private Data m_data;
        private bool? m_isWhiteOriented;
        private LayoutVisibility m_controlsVisibility;

        public Board()
        {
            InitializeComponent();

            Options.BoardOptionsChanged += DrawImage;
            Data = Parser.Parse(Constants.DEFAULT_INPUT);
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

        public void TakeSnapshot()
        {
            try
            {
                FileHelper.CreateDirIfNotExists(Options.Instance.SnapshotDirectory);
                SaveSnapshot(Path.Combine(Options.Instance.SnapshotDirectory, $"{m_data.Id}{Constants.SNAPSHOT_EXTENSION}"));
                Sound.Play(Sounds.Snapshot);
                Notification.Notify?.Invoke("Snapshot was saved");
            }
            catch
            {
                XtraMessageBox.Show(this, "Failed to snapshot image. Change Snapshot directory in Options and try again", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFlip_Click(object sender, EventArgs e)
        {
            m_isWhiteOriented = !m_isWhiteOriented;
            DrawImage(false);
            Sound.Play(Sounds.Flip);
        }

        private void ChangeControlsVisibility()
        {
            lciPlayers.Visibility = m_controlsVisibility;
            lciTimestamp.Visibility = m_controlsVisibility;
            lciOpening.Visibility = m_controlsVisibility;
            lciDefense.Visibility = m_controlsVisibility;
            lciFlip.Visibility = m_controlsVisibility;
        }

        private void DrawImage(bool resetOrientation)
        {
            if (resetOrientation)
            {
                m_isWhiteOriented = ShowOnlyBoard ? true : null;
            }

            imageBoard.Image = BoardImage.Create(m_data.Position, ref m_isWhiteOriented);
        }

        private void Reinitialize()
        {
            lblPlayers.Text = m_data.Comment.Players;
            lblTimestamp.Text = m_data.Comment.Timestamp;
            lblOpening.Text = m_data.Comment.Opening;
            lblDefense.Text = m_data.Comment.Defense;

            DrawImage(true);
        }

        private void SaveSnapshot(string fileName, int tryCount = 2)
        {
            if (!File.Exists(fileName))
            {
                imageBoard.Image.Save(fileName);
                return;
            }

            SaveSnapshot(Path.Combine(Options.Instance.SnapshotDirectory, $"{m_data.Id} ({tryCount}){Constants.SNAPSHOT_EXTENSION}"), tryCount + 1);
        }
    }
}

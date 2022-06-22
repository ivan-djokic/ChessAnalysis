using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
    public partial class MainForm : RibbonForm
    {
        private string m_savedFile = string.Empty;

        public MainForm()
        {
            Theme.ApplyTheme();
            InitializeComponent();
            Notification.Notify += SetNotification;
        }

        protected override void OnLoad(EventArgs e)
        {
            Sound.Play(Sounds.Start);
            base.OnLoad(e);
        }

        private void btnAdd_ItemClick(object sender, EventArgs e)
        { 
            using var addForm = new AddForm(panel.Collection);
            addForm.ShowDialog(this);
        }

        private void btnAddFromFile_ItemClick(object sender, EventArgs e)
        {
            using var addFromFileForm = new AddFromFileForm(panel.Collection);
            addFromFileForm.ShowDialog(this);
        }

        private void btnMail_ItemClick(object sender, EventArgs e)
        {
            var selection = panel.GetSelection();

            if (!selection.Any())
            {
                Alert.Error(this, Resources.NothingToSend, MessageBoxButtons.OK);
                return;
            }

            using var mailForm = new MailForm(selection);
            mailForm.ShowDialog(this);
        }

        private void btnOptions_ItemClick(object sender, EventArgs e)
        {
            using var optionsForm = new OptionsForm();
            optionsForm.ShowDialog(this);
        }

        private void btnSave_ItemClick(object sender, EventArgs e)
        {
            if (!File.Exists(m_savedFile))
            {
                btnSaveAs_ItemClick(new object(), EventArgs.Empty);
                return;
            }

            SaveCollection();
        }

        private void btnSaveAs_ItemClick(object sender, EventArgs e)
        {
            using var fileDialog = new XtraSaveFileDialog
            {
                Filter = Constants.DIALOG_FILTER,
                InitialDirectory = Options.Instance.LastOutputDirectory
            };

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_savedFile = fileDialog.FileName;
                SaveCollection();
            }
        }

        private void btnSnapshot_ItemClick(object sender, EventArgs e)
        {
            panel.TakeSnapshot();
        }

        private void RowCountChanged(int count)
        {
            lblTotalPositions.Caption = string.Format(Resources.TotalRows, count);
        }

        private void SaveCollection()
        {
            FileHelper.Save(m_savedFile, panel.Collection.ToString());
            Options.Instance.LastOutputDirectory = FileHelper.GetDirectoryName(m_savedFile);
            Options.Instance.Save();

            Sound.Play(Sounds.Save);
            Text = string.Format(Resources.MainCaption, Path.GetFileNameWithoutExtension(m_savedFile));
            Notification.Notify?.Invoke(string.Format(Resources.NotifySavedFile, Path.GetFileName(m_savedFile)));
        }

        private void SetNotification(string message)
        {
            lblNotification.Caption = message;
            timer.Restart();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            lblNotification.Caption = string.Empty;
        }
    }
}
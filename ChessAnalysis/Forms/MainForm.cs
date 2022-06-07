using System.IO;
using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
    public partial class MainForm : RibbonForm
    {
        private string m_savedFile = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            SetIcons();
            Notification.Notify += SetNotification;
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            SetIcons();
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
            using var mailForm = new MailForm(panel.Collection);
            
            if (mailForm.ShowDialog(this) == DialogResult.OK)
            {
                SetNotification("Mail was sent");
            }
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
                InitialDirectory = Options.Instance.LastInputDirectory
            };

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_savedFile = fileDialog.FileName;
                SaveCollection();
            }
        }

        private void btnSnapshot_ItemClick(object sender, EventArgs e)
        {
            try
            {
                panel.TakeSnapshot();
                SetNotification("Snapshot was saved");
            }
            catch
            {
                XtraMessageBox.Show(this, "Failed to snapshot image. Change Snapshot directory in Options and try again", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RowCountChanged(int count)
        {
            lblTotalPositions.Caption = string.Format(Strings.TotalPositions, count);
        }

        private void SaveCollection()
        {
            FileHelper.Save(m_savedFile, panel.Collection.ToString());
            SetNotification("File was saved");

            Options.Instance.LastOutputDirectory = FileHelper.GetDirectoryName(m_savedFile);
            Options.Instance.Save();
        }

        private void SetIcons()
        {
            // Do not change names of buttons in Designer because this is hardcoded with Resources
            foreach (var item in Main.Items)
            {
                if (item is BarButtonItem button)
                {
                    button.ImageOptions.LargeImage = Resources.GetThemedIcon(button.Name);
                }
            }
        }

        private void SetNotification(string message)
        {
            lblNotification.Caption = message;
            timer.Stop();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            lblNotification.Caption = string.Empty;
        }
    }
}
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
        }

        protected override void OnBackColorChanged(EventArgs e)
        {
            SetIcons();
        }

        private void btnAdd_ItemClick(object sender, EventArgs e)
        { 
            using var addForm = new AddForm();
            addForm.ShowDialog(this);
        }

        private void btnAddFromFile_ItemClick(object sender, EventArgs e)
        {
            using var addFromFileForm = new AddFromFileForm(panel.Collection);
            addFromFileForm.ShowDialog(this);
        }

        private void btnMail_ItemClick(object sender, EventArgs e)
        {
            Mailing.SendMail(panel.Collection);
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

            FileHelper.Save(m_savedFile, panel.Collection.ToString());
        }

        private void btnSaveAs_ItemClick(object sender, EventArgs e)
        {
            using var fileDialog = new XtraSaveFileDialog();

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_savedFile = fileDialog.FileName;
                FileHelper.Save(m_savedFile, panel.Collection.ToString());
            }
        }

        private void btnSnapshot_ItemClick(object sender, EventArgs e)
        {
            try
            {
                panel.TakeSnapshot();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(this, ex.Message, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RowCountChanged(int count)
        {
            lblTotalPositions.Caption = string.Format(Strings.TotalPositions, count);
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
    }
}
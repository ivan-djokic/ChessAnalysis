using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace ChessAnalysis.Controls
{
    public partial class GeneralTab : XtraUserControl
    {
        public GeneralTab()
        {
            InitializeComponent();
            Reinitialize();
        }

        public void Reinitialize()
        {
            txtSnapshotDirectory.Text = Options.Instance.DefaultSnapshotDirectory;
            rbDark.Checked = Options.Instance.Theme == Themes.Dark;
            rbLight.Checked = Options.Instance.Theme == Themes.Light;
        }

        public void SaveOptions()
        {
            Options.Instance.DefaultSnapshotDirectory = txtSnapshotDirectory.Text;
            Options.Instance.Theme = rbDark.Checked ? Themes.Dark : Themes.Light;
        }

		private void txtSnapshotDirectory_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
            using var browserDialog = new XtraFolderBrowserDialog
            {
                SelectedPath = Options.Instance.DefaultSnapshotDirectory
            };
            
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSnapshotDirectory.Text = browserDialog.SelectedPath;
            }
        }
	}
}

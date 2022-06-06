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
            BindComponents();
        }

        private void BindComponents()
        {
            Options.Instance.Bind(txtSnapshotDirectory, model => model.SnapshotDirectory);
            Options.Instance.Bind(rbDark, model => model.ThemeDark);
            Options.Instance.Bind(rbLight, model => model.ThemeLight);
            Options.Instance.Bind(rbEnglish, model => model.LanguageEnglish);
            Options.Instance.Bind(rbSrpski, model => model.LanguageSrpski);
            Options.Instance.Bind(chxPlaySound, model => model.PlaySound);
        }

        private void txtSnapshotDirectory_ButtonClick(object sender, ButtonPressedEventArgs e)
		{
            using var browserDialog = new XtraFolderBrowserDialog
            {
                SelectedPath = Options.Instance.SnapshotDirectory
            };
            
            if (browserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSnapshotDirectory.Text = browserDialog.SelectedPath;
            }
        }
    }
}

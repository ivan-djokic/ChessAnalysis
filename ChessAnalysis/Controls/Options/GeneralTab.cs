// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

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
			Options.Instance.Bind(chxPlaySound, model => model.PlaySound);
		}

		private void txtSnapshotDirectory_ButtonClick(object sender, EventArgs e)
		{
			using var browserDialog = new XtraFolderBrowserDialog
			{
				SelectedPath = Options.Instance.SnapshotDirectory,
				StartPosition = FormStartPosition.CenterParent
			};

			if (browserDialog.ShowDialog(this) == DialogResult.OK)
			{
				txtSnapshotDirectory.Text = browserDialog.SelectedPath;
			}
		}
	}
}

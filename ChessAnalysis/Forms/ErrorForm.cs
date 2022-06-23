using ChessAnalysis.Models;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class ErrorForm : XtraForm
	{
		public ErrorForm(IEnumerable<Error> errors)
		{
			InitializeComponent();
			grid.Reinitialize(errors);
		}

		protected override void OnLoad(EventArgs e)
		{
			Sound.Play(Sounds.Error);
			base.OnLoad(e);
		}

		protected override bool ProcessDialogKey(Keys keyData)
		{
			if (keyData == Keys.Escape)
			{
				Close();
				return true;
			}

			return base.ProcessDialogKey(keyData);
		}
	}
}
// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Forms;
using ChessAnalysis.Models;
using ChessAnalysis.Properties;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
	public static class Messanger
	{
		public static bool ShowError(IWin32Window owner, string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
		{
			return XtraMessageBox.Show(owner, message, Resources.ErrorCaption, buttons, MessageBoxIcon.Error) == DialogResult.Yes;
		}

		public static bool ShowErrorList(IWin32Window owner, IEnumerable<Error> errors)
		{
			using var errorForm = new ErrorForm(errors);
			return errorForm.ShowDialog(owner) == DialogResult.Yes;
		}

		public static bool ShowWarning(IWin32Window owner, string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
		{
			return XtraMessageBox.Show(owner, message, Resources.WarningCaption, buttons, MessageBoxIcon.Warning) == DialogResult.Yes;
		}
	}
}

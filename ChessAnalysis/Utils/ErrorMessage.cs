using ChessAnalysis.Forms;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
    public static class ErrorMessage
    {
        public static bool Show(IWin32Window owner, string message, MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return XtraMessageBox.Show(owner, message, Constants.ERROR_CAPTION, buttons, MessageBoxIcon.Error) == DialogResult.Yes;
        }

        public static bool ShowList(IWin32Window owner, IEnumerable<Error> errors)
        {
            using var errorForm = new ErrorForm(errors);
            return errorForm.ShowDialog(owner) == DialogResult.Yes;
        }
    }
}

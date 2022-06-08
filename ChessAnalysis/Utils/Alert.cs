﻿using ChessAnalysis.Forms;
using ChessAnalysis.Models;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Utils
{
    public static class Alert
    {
        public static bool Error(IWin32Window owner, string message, MessageBoxButtons buttons = MessageBoxButtons.YesNo)
        {
            return XtraMessageBox.Show(owner, message, "Error message", buttons, MessageBoxIcon.Error) == DialogResult.Yes;
        }

        public static bool ErrorList(IWin32Window owner, IEnumerable<Error> errors)
        {
            using var errorForm = new ErrorForm(errors);
            return errorForm.ShowDialog(owner) == DialogResult.Yes;
        }
    }
}
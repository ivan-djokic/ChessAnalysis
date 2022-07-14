// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
	public partial class MailTab : XtraUserControl
	{
		public MailTab()
		{
			InitializeComponent();
			BindComponents();
		}

		private void BindComponents()
		{
			Options.Instance.Bind(txtSmtpClient, model => model.SmtpClient);
			Options.Instance.Bind(txtMail, model => model.SenderMail);
			Options.Instance.Bind(txtPassword, model => model.SenderPassword);
		}
	}
}

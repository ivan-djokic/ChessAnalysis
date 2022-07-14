// -----------------------------------------------
// © 2022 [ELFAK] Ivan Djokic. ALL RIGHTS RESERVED
// -----------------------------------------------

using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace ChessAnalysis.Forms
{
	public partial class MailForm : XtraForm
	{
		private readonly DataCollection m_collection;

		public MailForm(DataCollection collection)
		{
			InitializeComponent();
			m_collection = collection;
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			var handle = SplashScreenManager.ShowOverlayForm(this);

			try
			{
				mail.Send(m_collection);
				Close();
			}
			catch
			{
				SplashScreenManager.CloseOverlayForm(handle);
				Messanger.ShowError(this, Resources.MailError);
			}
		}
	}
}

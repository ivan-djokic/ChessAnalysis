using System.Net;
using System.Net.Mail;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Forms
{
	public partial class MailForm : XtraForm
	{
        private readonly DataCollection m_collection;

		public MailForm(DataCollection collection)
		{
			InitializeComponent();
            
            m_collection = collection;
            BindComponents();
        }

        private void BindComponents()
        {
            Options.Instance.Bind(txtReceiver, model => model.ReceiverMail);
            Options.Instance.Bind(txtContent, model => model.MailContent);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Options.Instance.Save();

            try
            {
                SendMail();
                DialogResult = DialogResult.OK;
            }
            catch
            {
                XtraMessageBox.Show(this, "Error in Mail sender or receiver configuration. Change configuration parameters and try again", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SendMail()
        {
            var client = new SmtpClient(Options.Instance.SmtpClient)
            {
                Credentials = new NetworkCredential(Options.Instance.SenderMail, Options.Instance.SenderPassword),
                EnableSsl = true
            };

            using var message = new MailMessage(new MailAddress(Options.Instance.SenderMail), new MailAddress(Options.Instance.ReceiverMail))
            {
                Body = HtmlBuilder.BuildPage(Options.Instance.MailContent, m_collection),
                IsBodyHtml = true,
                Subject = "Chess analysis"
            };

            client.Send(message);
        }
    }
}
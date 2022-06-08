using System.Net;
using System.Net.Mail;
using ChessAnalysis.Classes;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class Mail : XtraUserControl
    {
        public Mail()
        {
            InitializeComponent();
            BindComponents();
        }

        public void Send(DataCollection collection)
        {
            var client = new SmtpClient(Options.Instance.SmtpClient)
            {
                Credentials = new NetworkCredential(Options.Instance.SenderMail, Options.Instance.SenderPassword),
                EnableSsl = true
            };

            using var message = new MailMessage(Options.Instance.SenderMail, txtReceiver.Text)
            {
                Body = HtmlBuilder.BuildPage(txtContent.Text, collection),
                IsBodyHtml = true,
                Subject = "Chess analysis"
            };

            client.Send(message);

            Options.Instance.Save();
            Sound.Play(Sounds.Mail);
            Notification.Notify?.Invoke("Mail was sent");
        }

        private void BindComponents()
        {
            Options.Instance.Bind(txtReceiver, model => model.ReceiverMail);
            Options.Instance.Bind(txtContent, model => model.MailContent);
        }
    }
}

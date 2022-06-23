using System.IO;
using System.Net;
using System.Net.Mail;
using ChessAnalysis.Classes;
using ChessAnalysis.Properties;
using ChessAnalysis.Utils;
using DevExpress.XtraEditors;

namespace ChessAnalysis.Controls
{
    public partial class Mail : XtraUserControl
    {
        private string[]? m_attachments;

        public Mail()
        {
            InitializeComponent();
            BindComponents();
        }

        public void Send(DataCollection collection)
        {
            using var client = new SmtpClient(Options.Instance.SmtpClient)
            {
                Credentials = new NetworkCredential(Options.Instance.SenderMail, Options.Instance.SenderPassword),
                EnableSsl = true
            };

            using var message = new MailMessage(Options.Instance.SenderMail, txtReceiver.Text)
            {
                Body = HtmlBuilder.BuildPage(txtContent.Text, collection),
                IsBodyHtml = true,
                Subject = Constants.APP_NAME
            };

            SetAttachments(message);
            client.Send(message);
            Options.Instance.Save();

            Sound.Play(Sounds.Mail);
            Notification.Notify?.Invoke(Resources.NotifyMail);
        }

        private void BindComponents()
        {
            Options.Instance.Bind(txtReceiver, model => model.ReceiverMail);
            Options.Instance.Bind(txtContent, model => model.MailContent);
        }

        private void SetAttachments(MailMessage message)
        {
            if (m_attachments == null)
            {
                return;
            }

            foreach (var fileName in m_attachments)
            {
                try
                {
                    message.Attachments.Add(new Attachment(fileName));
                }
                catch
                {

                }
            }

            if (message.Attachments.Count == m_attachments.Length)
            {
                return;
            }

            if (!ErrorMessage.Show(this, Resources.AttachmentsMissing))
            {
                message.Attachments.Clear();
            }
        }

        private void txtAttachments_ButtonClick(object sender, EventArgs e)
        {
            using var fileDialog = new XtraOpenFileDialog
            {
                AllowDragDrop = false,
                InitialDirectory = Options.Instance.SnapshotDirectory,
                Multiselect = true,
                StartPosition = FormStartPosition.CenterParent
            };

            m_attachments = null;

            if (fileDialog.ShowDialog(this) == DialogResult.OK)
            {
                m_attachments = fileDialog.FileNames;
                txtAttachments.Text = string.Join(Constants.COMA_SEPARATOR, m_attachments.Select(a => Path.GetFileName(a)));
            }
        }
    }
}

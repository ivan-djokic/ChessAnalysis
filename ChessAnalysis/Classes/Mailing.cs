using System.Net;
using System.Net.Mail;

namespace ChessAnalysis.Classes
{
    public class Mailing
    {
        public static void SendMail(DataCollection collection)
        {
            var fromAddress = new MailAddress("chess.analysis.bot@gmail.com", "Chess analysis bot");
            var toAddress = new MailAddress("ivan.djokic.besko@gmail.com");
            string fromPassword = "analysis64#";

            var client = new SmtpClient("smtp.gmail.com")
            {
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                EnableSsl = true
            };

            using var message = new MailMessage(fromAddress, toAddress)
            {
                Body = HtmlBuilder.BuildPage("neki tekst" + Environment.NewLine + "je tuj", collection),
                IsBodyHtml = true,
                Subject = "Chess analysis"
            };

            client.Send(message);
        }
    }
}
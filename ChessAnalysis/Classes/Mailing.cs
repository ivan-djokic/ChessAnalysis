using System.Net;
using System.Net.Mail;

namespace ChessAnalysis.Classes
{
    public class Mailing
    {
        public static void SendMail()
        {
            var fromAddress = new MailAddress("chess.analysis.bot@gmail.com", "Chess analysis bot");
            var toAddress = new MailAddress("ivan.djokic.besko@gmail.com");
            const string fromPassword = "analysis64#";
            const string subject = "Chess analysis";
            const string body = @"<!DOCTYPE html>
<html>
<head>
<style>
table {
  font-family: arial, sans-serif;
  border-collapse: collapse;
  width: 100%;
}

td, th {
  border: 1px solid #dddddd;
  padding: 2px;
}

tr:nth-child(even) {
  background-color: #dddddd;
}
</style>
</head>
<body>

<h2>HTML Table</h2>

<table>
  <tr>
    <th>Company</th>
    <th>Contact</th>
    <th>Country</th>
  </tr>
  <tr>
    <td>Alfreds Futterkiste</td>
    <td>Maria Anders</td>
    <td>Germany</td>
  </tr>
  <tr>
    <td>Centro comercial Moctezuma</td>
    <td>Francisco Chang</td>
    <td>Mexico</td>
  </tr>
  <tr>
    <td>Ernst Handel</td>
    <td>Roland Mendel</td>
    <td>Austria</td>
  </tr>
  <tr>
    <td>Island Trading</td>
    <td>Helen Bennett</td>
    <td>UK</td>
  </tr>
  <tr>
    <td>Laughing Bacchus Winecellars</td>
    <td>Yoshi Tannamuri</td>
    <td>Canada</td>
  </tr>
  <tr>
    <td>Magazzini Alimentari Riuniti</td>
    <td>Giovanni Rovelli</td>
    <td>Italy</td>
  </tr>
</table>

</body>
</html>";

            var smtp = new SmtpClient("smtp.gmail.com")
            {
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                EnableSsl = true
            };

            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Body = body,
                IsBodyHtml = true,
                Subject = subject
            })
            {
                message.Attachments.Add(new Attachment(@"C:\Users\IDjokic\OneDrive - Quest\Documents\Chess Analysis\Snapshots\KK03.png"));
                smtp.Send(message);
            }
        }
    }
}
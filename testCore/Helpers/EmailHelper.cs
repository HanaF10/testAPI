using System.Net;
using System.Net.Mail;

namespace testAPI.testCore.Helpers
{
    public class EmailHelper
    {
        public static bool SendMail()
        {
            string body = "<head>" +
            "Here comes some logo" +
        "</head>" +
        "<body>" +
            "<h1>Account confirmation reqest.</h1>" + Environment.NewLine +
            "<a>Dear User, </a>" + Environment.NewLine +
            "<a>In order to be able to use musicshop app properly, we require You to confirm Your email address.</a>" + Environment.NewLine +
            "<a>This is the last step towards using our app.</a>" + Environment.NewLine +
            "<a>Pleas follow this hyperlink to confirm your address.</a>" + Environment.NewLine +
            "<a>[Callback url]</a>" +
        "</body>";
            try
            {
                using (var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential()
                    {
                        //keep this in AppSettings
                        UserName = "cchulda@gmail.com",
                        Password = "2001002704",
                    };
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.EnableSsl = true;
                    MailMessage mailMessage = new MailMessage("cchulda@gmail.com", "cchulda@gmail.com","test",body);
                    mailMessage.IsBodyHtml = true;
                    smtpClient.Send(mailMessage);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("{0}: {1}", e.ToString(), e.Message);
                return false;
            }
            return true;
        }
        
    }
}

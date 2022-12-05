using System;
using System.Globalization;
using System.Net.Mail;
using System.Net.Mime;
using System.Text.RegularExpressions;

using SendGrid;
using SendGrid.Helpers.Mail;


namespace IST.RRHH.Domain
{
    public class Email
    {
        public string smtp { get; set; }
        public string emailOrigen { get; set; }
        public string passwordOrigen { get; set; }
        public int port { get; set; }
        public bool enableSsl { get; set; }

        public static bool IsValidMail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public bool EnviarEmail(string para, string asunto, string body, string cc = "")
        {
            try
            {
                ProcesoEnviarMail(para, asunto, body);
                return true;

            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
                //return false;
                throw ex;
            }
        }

        public void ProcesoEnviarMail(string para, string asunto, string body, string cc = "")
        {

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient(smtp);

            mail.From = new MailAddress(emailOrigen);
            //

            string[] paraList = para.Split(';');
            foreach (var item in paraList)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    mail.To.Add(item.Trim());
                }
            }

            string[] ccList = cc.Split(';');
            foreach (var item in ccList)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    mail.CC.Add(item.Trim());
                }
            }

            mail.Subject = asunto;
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpServer.Port = port;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential(emailOrigen, passwordOrigen);
            SmtpServer.EnableSsl = enableSsl;

            SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
            SmtpServer.Send(mail);
        }
    }
}

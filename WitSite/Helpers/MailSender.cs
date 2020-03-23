using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using WitSite.Interfaces;
using WitSite.Models;

namespace WitSite.Helpers
{
    public class MailSender : IMailSender<ClientInfo>
    {
        public void SendMail(ClientInfo item)
        {
            try
            {
                MailAddress from = new MailAddress("wit@gmail.com");
                MailAddress to = new MailAddress("kolotseymax@gmail.com");

                MailMessage mail = new MailMessage(from,to);
                mail.Subject="Новая заявка!";
                mail.IsBodyHtml = true;
                mail.Body = $"<div><h2>Поздравляю! У нас новая заявка!</h2><p>Имя клиента: <strong>{item.Name}</strong></p><p>Email клиента: <strong>{item.Email}</strong></p><p>Телефон клиента: <strong>{item.Tel}</strong></p></div>";
                SmtpClient client = new SmtpClient("smtp.gmail.com");

                client.Credentials = new NetworkCredential("kolotseymax@gmail.com", "adxlrmawzuweblnk");
                client.EnableSsl = true;
                client.Send(mail);
            }
            catch(Exception e)
             {

            }
        }
    }
}

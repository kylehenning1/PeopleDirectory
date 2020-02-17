using PeopleDirectory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace PeopleDirectory.Helpers
{
    public class EmailHelper
    {
        public static async System.Threading.Tasks.Task sendEmailAsync(List<Client> clientPrePostEdit)
        {
            var body = $"<p>Hi Admin,</p>" +
                $"<p>User <b>{clientPrePostEdit[0].Name} {clientPrePostEdit[0].Surname}</b> was updated</p>";

            if (clientPrePostEdit[0].Name != clientPrePostEdit[1].Name)
                body += $"<p>Name was changed from <b>{clientPrePostEdit[0].Name}</b> to <b>{clientPrePostEdit[1].Name}</b>.</p>";
            if (clientPrePostEdit[0].Surname != clientPrePostEdit[1].Surname)
                body += $"<p>Surname was changed from <b>{clientPrePostEdit[0].Surname}</b> to <b>{clientPrePostEdit[1].Surname}</b>.</p>";
            if (clientPrePostEdit[0].Location != clientPrePostEdit[1].Location)
                body += $"<p>Location was changed from <b>{clientPrePostEdit[0].Location}</b> to <b>{clientPrePostEdit[1].Location}</b>.</p>";
            if (clientPrePostEdit[0].MobileNumber != clientPrePostEdit[1].MobileNumber)
                body += $"<p>Mobile Number was changed from <b>{clientPrePostEdit[0].MobileNumber}</b> to <b>{clientPrePostEdit[1].MobileNumber}</b>.</p>";
            if (clientPrePostEdit[0].Email != clientPrePostEdit[1].Email)
                body += $"<p>Email was changed from <b>{clientPrePostEdit[0].Email}</b> to <b>{clientPrePostEdit[1].Email}</b>.</p>";
            if (clientPrePostEdit[0].Gender != clientPrePostEdit[1].Gender)
                body += $"<p>Gender was changed from <b>{clientPrePostEdit[0].Gender}</b> to <b>{clientPrePostEdit[1].Gender}</b>.</p>";
            if (clientPrePostEdit[0].ProfilePic != clientPrePostEdit[1].ProfilePic)
                body += $"<p>Profile Pic was changed from <b>{clientPrePostEdit[0].ProfilePic}</b> to <b>{clientPrePostEdit[1].ProfilePic}</b>.</p>";

            body += $"<p>Kind Regards,<br/>The project team</p>";


            var message = new MailMessage();
            message.To.Add(new MailAddress("kylehenning1@gmail.com"));
            message.Subject = "Bluegrass Assignment";
            message.Body = body;
            message.IsBodyHtml = true;
            using (var smtp = new SmtpClient())
            {
                await smtp.SendMailAsync(message);
            }
        }
    }
}
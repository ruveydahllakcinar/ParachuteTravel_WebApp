using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using ParachuteTravel.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParachuteTravel.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    public class MailController : Controller
    {

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(MailRequestViewModel mailRequest)
        {
            MimeMessage mimeMessage = new();
            MailboxAddress mailboxAddressFrom = new("Admin", "parachutetravelwepapp@gmail.com");

            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new("User", mailRequest.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);

            var contentBuilder = new BodyBuilder();
            contentBuilder.TextBody = mailRequest.Content;
            mimeMessage.Body = contentBuilder.ToMessageBody();

            mimeMessage.Subject = mailRequest.Subject;
            //mimeMessage.Content = mailRequest.Content;
            SmtpClient client = new();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("parachutetravelwepapp@gmail.com", "anwczkpcgvrjvetn");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
        }
    }
}

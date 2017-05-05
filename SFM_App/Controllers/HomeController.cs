using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCEmail.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SFM_App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home";
            return View();
        }

        public ActionResult Team()
        {
            ViewBag.Title = "Team";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "Contact";
            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Title = "Services";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(ContactFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("colby.armstrong@signalfyre.ca"));
                message.From = new MailAddress("colby.armstrong@signalfyre.ca");
                message.Subject = "Message from SignalFyre Contact Form";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "colby.armstrong@signalfyre.ca",
                        Password = "FyreFyre123!"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.office365.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = false;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }
    }
}
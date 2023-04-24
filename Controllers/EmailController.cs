using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace EmailSender.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            // var email=new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("telly.brakus@ethereal.email"));
            // email.To.Add(MailboxAddress.Parse("telly.brakus@ethereal.email"));
            // email.Subject = "Test Email";
            // email.Body=new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

            // using var smtp = new SmtpClient();
            // smtp.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls); //smtp.gmail.com
            // smtp.Authenticate("telly.brakus@ethereal.email", "26RjnpNeBywRRSPpyy");
            // smtp.Send(email);
            //  smtp.Disconnect(true);

            _emailService.SendEmail(request);

            return Ok();


        }
    }
}

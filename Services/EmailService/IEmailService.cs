using EmailSender.Model;

namespace EmailSender.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(EmailDto request);

    }
}

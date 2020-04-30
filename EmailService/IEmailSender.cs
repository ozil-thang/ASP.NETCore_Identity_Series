using System.Threading.Tasks;

namespace IdentitySeries.EmailService
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
        Task SendEmailAsync(Message message);
    }
}
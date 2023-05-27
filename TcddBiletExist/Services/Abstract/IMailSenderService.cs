using MimeKit;
using TcddBiletExist.Models;

namespace TcddBiletExist.Services.Abstract
{
    public interface IMailSenderService
    {
        Task<MimeMessage> Create(MailMessage message);
    }
}

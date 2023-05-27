using MimeKit;
using TcddBiletExist.Models;
using TcddBiletExist.Providers;
using TcddBiletExist.Services.Abstract;

namespace TcddBiletExist.Services.Concrete
{
    internal class MailSenderService : IMailSenderService
    {
        private LogProvider _logProvider;

        public MailSenderService(LogProvider logProvider)
        {
            _logProvider = logProvider;
        }

        public Task<MimeMessage> Create(MailMessage message)
        {
            try
            {
                var mailMessage = new MimeMessage();

                mailMessage.From.Add(new MailboxAddress(message.FromName, message.FromMail));

                if (message.To != null)
                {
                    foreach (KeyValuePair<string, string> entry in message.To)
                    {
                        mailMessage.To.Add(new MailboxAddress(entry.Key, entry.Value));
                    }
                }

                mailMessage.Subject = message.Subject;

                mailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
                {
                    Text = message.Body,
                };

                return Task.FromResult(mailMessage);
            }
            catch (Exception exc)
            {
                _logProvider.AddLog(new Models.Log()
                {
                    Message = exc.Message,
                    Type = Models.LogType.Warning
                });
                throw;
            }
        }
    }
}

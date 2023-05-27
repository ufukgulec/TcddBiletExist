using MailKit.Net.Smtp;
using MimeKit;

namespace TcddBiletExist.Providers
{
    public class MailProvider
    {
        public async Task<bool> SendAsync(MimeMessage email)
        {
            using (var smtp = new SmtpClient())
            {
                await smtp.ConnectAsync("smtp.gmail.com", 587, false);

                await smtp.AuthenticateAsync(AppSettings.Default.ClientMailAddress, AppSettings.Default.ClientMailPassword);

                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);

                return true;
            }
        }
    }
}

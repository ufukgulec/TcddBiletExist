using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models
{
    public class MailMessage
    {
        public string? FromName { get; set; }
        public string? FromMail { get; set; }
        public Dictionary<string, string>? To { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}

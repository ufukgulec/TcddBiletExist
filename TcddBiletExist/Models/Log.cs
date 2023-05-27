using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models
{
    public enum LogType { Error = 1, Warning = 2, Information = 3 }

    public class Log
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Message { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
        public LogType Type { get; set; }
    }
}

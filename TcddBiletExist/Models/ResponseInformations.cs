using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models
{
    public class ResponseInformations
    {
        public string CevapKodu { get; set; }
        public string CevapMsj { get; set; }
        public object? Detay { get; set; }
    }
}

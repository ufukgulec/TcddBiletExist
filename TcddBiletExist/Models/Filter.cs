using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models
{
    public class Filter
    {
        public string binisIstasyonuAdi { get; set; }
        public long binisIstasyonuKod { get; set; }
        public string inisIstasyonuAdi { get; set; }
        public long inisIstasyonuKod { get; set; }
        public string gidisTarih { get; set; }
        public long yolcuSayisi { get; set; }
    }
}

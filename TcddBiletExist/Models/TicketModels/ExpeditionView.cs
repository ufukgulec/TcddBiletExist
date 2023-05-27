using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models.TicketModels
{
    public class ExpeditionView
    {
        public string trenAdi { get; set; }
        public string trenTipi { get; set; }
        public DateTime binisTarih { get; set; }
        public DateTime inisTarih { get; set; }
        public string vagonTip { get; set; }
        public int kalanSayi { get; set; }
        public decimal standartBiletFiyati { get; set; }
    }
}

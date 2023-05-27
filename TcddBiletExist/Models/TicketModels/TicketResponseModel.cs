using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models.TicketModels
{
    public class TicketResponseModel
    {
        public ResponseInformations cevapBilgileri { get; set; }
        public List<Expedition> seferSorgulamaSonucList { get; set; }
    }
}

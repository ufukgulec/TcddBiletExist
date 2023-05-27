using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models.StationModels
{
    public class StationInformation
    {
        public long IstasyonId { get; set; }
        public string IstasyonKodu { get; set; }
        public string IstasyonAdi { get; set; }
        public string Enlem { get; set; }
        public string Boylam { get; set; }
        public string Rakim { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Eposta { get; set; }
        public bool IstasyonDurumu { get; set; }
        public bool EngelliRampasi { get; set; }
        public bool TasimaPlatformu { get; set; }
        public bool TekerlekliSandalye { get; set; }
        public bool HaritaGosterimi { get; set; }
        public bool SatisSorgudaGelsin { get; set; }
        public string Tarih { get; set; }
        public object GiseAciklikDurumu { get; set; }
        public object PersonelId { get; set; }
        public List<long> ToStationIds { get; set; }
        public string BolgeKodu { get; set; }
        public List<string> StationTrainTypes { get; set; }
        public string StationViewName { get; set; }
    }
}

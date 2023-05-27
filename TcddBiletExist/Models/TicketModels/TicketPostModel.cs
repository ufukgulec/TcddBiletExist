using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcddBiletExist.Models.TicketModels
{
    public class TicketPostModel
    {
        [JsonProperty("kanalKodu")]
        public long kanalKodu { get; set; }

        [JsonProperty("dil")]
        public long dil { get; set; }

        [JsonProperty("seferSorgulamaKriterWSDVO")]
        public SeferSorgulamaKriter seferSorgulamaKriterWSDVO { get; set; }
    }

    public class SeferSorgulamaKriter
    {
        [JsonProperty("satisKanali")]
        public long satisKanali { get; set; }

        [JsonProperty("binisIstasyonu")]
        public string binisIstasyonu { get; set; }

        [JsonProperty("binisIstasyonu_isHaritaGosterimi")]
        public bool binisIstasyonu_isHaritaGosterimi { get; set; }

        [JsonProperty("inisIstasyonu")]
        public string inisIstasyonu { get; set; }

        [JsonProperty("inisIstasyonu_isHaritaGosterimi")]
        public bool inisIstasyonu_isHaritaGosterimi { get; set; }

        [JsonProperty("seyahatTuru")]
        public long seyahatTuru { get; set; }

        [JsonProperty("gidisTarih")]
        public string gidisTarih { get; set; }

        [JsonProperty("bolgeselGelsin")]
        public bool bolgeselGelsin { get; set; }

        [JsonProperty("islemTipi")]
        public long islemTipi { get; set; }

        [JsonProperty("yolcuSayisi")]
        public long yolcuSayisi { get; set; }

        [JsonProperty("aktarmalarGelsin")]
        public bool aktarmalarGelsin { get; set; }

        [JsonProperty("binisIstasyonId")]
        public long binisIstasyonId { get; set; }

        [JsonProperty("inisIstasyonId")]
        public long inisIstasyonId { get; set; }
    }

}

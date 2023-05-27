using Newtonsoft.Json;

namespace TcddBiletExist.Models.StationModels
{
    public class StationPostRequestModel
    {

        public long KanalKodu { get; set; }

        public long Dil { get; set; }

        public string? Tarih { get; set; }

        public bool SatisSorgu { get; set; }
    }
}

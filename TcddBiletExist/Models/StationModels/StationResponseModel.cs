namespace TcddBiletExist.Models.StationModels
{
    public class StationResponseModel
    {
        public ResponseInformations CevapBilgileri { get; set; }
        public long? Sayi { get; set; }
        public List<StationInformation> IstasyonBilgileriList { get; set; }
    }
}

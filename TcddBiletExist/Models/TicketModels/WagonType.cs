namespace TcddBiletExist.Models.TicketModels
{
    public class WagonType
    {
        public long vagonTipId { get; set; }
        public string vagonTip { get; set; }
        public long mevkiNo { get; set; }
        public int kalanSayi { get; set; }
        public long hesapliBiletFiyati { get; set; }
        public double standartBiletFiyati { get; set; }
        public long esnekBiletFiyati { get; set; }
        public List<Wagon> vagonListesi { get; set; }
        public long ubsKodu { get; set; }
        public long gosterimArtiUcret { get; set; }
        public long kalanEngelliKoltukSayisi { get; set; }
        public long kalanYatakSayisi { get; set; }
    }
}
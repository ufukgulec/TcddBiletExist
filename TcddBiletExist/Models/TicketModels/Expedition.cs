namespace TcddBiletExist.Models.TicketModels
{
    public class Expedition
    {
        public long aktarmaNo { get; set; }
        public long aktarmaSiraNo { get; set; }
        public long seyahatTuru { get; set; }
        public long trenId { get; set; }
        public string trenAdi { get; set; }
        public string trenTipi { get; set; }
        public string trenKodu { get; set; }
        public long trenTuruTktId { get; set; }
        public string seferAdi { get; set; }
        public long seferId { get; set; }
        public string binisTarih { get; set; }
        public string inisTarih { get; set; }
        public List<WagonType> vagonTipleriBosYerUcret { get; set; }
        public long satisDurum { get; set; }
        public long rezDurum { get; set; }
        public string binisIstasyonu { get; set; }
        public string inisIstasyonu { get; set; }
        public ExpeditionImpression seferGosterimDVO { get; set; }
        public long vagonHaritasindanKoltukSecimi { get; set; }
        public long rezUcretOrani { get; set; }
        public long rezUcretTutari { get; set; }
        public bool bolgeselTren { get; set; }
        public long binisIstasyonId { get; set; }
        public long inisIstasyonId { get; set; }
        public List<ExpeditionWagon> seferVagonListesi { get; set; }
        public bool hesapliBiletIade { get; set; }
        public bool hesapliBiletDegisiklik { get; set; }
        public bool standartBiletIade { get; set; }
        public bool standartBiletDegisiklik { get; set; }
        public bool esnekBiletIade { get; set; }
        public bool esnekBiletDegisiklik { get; set; }
        public bool tersTren { get; set; }
        public double minimumTasimaUcreti { get; set; }
        public string gunNotu { get; set; }
        public bool hesapliBiletAcigaCevirme { get; set; }
        public bool standartBiletAcigaCevirme { get; set; }
        public bool esnekBiletAcigaCevirme { get; set; }
        public long hesapliBiletDegisiklikHakki { get; set; }
        public long standartBiletDegisiklikHakki { get; set; }
        public long esnekBiletDegisiklikHakki { get; set; }
        public bool captcha { get; set; }
        public object durusTablosu { get; set; }
        public object iliskiTipi { get; set; }
        public object kirilimOrtakVagonlarDVOs { get; set; }
        public object bolgeselTrenKalanBiletSayisi { get; set; }
    }
}
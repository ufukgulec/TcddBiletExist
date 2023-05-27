namespace TcddBiletExist.Models.TicketModels
{
    public class ExpeditionWagon
    {
        public object seferTeskilatId { get; set; }
        public object seferBaslikId { get; set; }
        public object vagonBaslikId { get; set; }
        public long vagonSiraNo { get; set; }
        public long baslangicIstasyonId { get; set; }
        public long bitisIstasyonId { get; set; }
        public bool aktif { get; set; }
        public string baslangicIstasyonAdi { get; set; }
        public string bitisIstasyonAdi { get; set; }
        public int bosYer { get; set; }
    }
}
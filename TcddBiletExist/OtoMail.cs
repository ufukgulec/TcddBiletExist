using System.Data;
using System.Reflection;
using System.Text;
using TcddBiletExist.Helpers;
using TcddBiletExist.Models;
using TcddBiletExist.Models.TicketModels;
using TcddBiletExist.Providers;
using TcddBiletExist.Services.Concrete;

namespace TcddBiletExist
{
    public partial class OtoMail : Form
    {
        enum Stations { AnkaraGar = 234516259, Sivas = 234517773 }
        private RequestProvider requestProvider = new RequestProvider();
        private LogProvider logProvider = new LogProvider();
        private MailProvider mailProvider = new MailProvider();
        private LogProviderService logService = new LogProviderService();

        public OtoMail()
        {
            InitializeComponent();
        }

        private async void OtoMail_LoadAsync(object sender, EventArgs e)
        {
            await find_ticketAsync();
            //this.Close();
            System.Environment.Exit(1);
        }

        private async Task<bool> find_ticketAsync()
        {
            TicketPostModel model = new TicketPostModel()
            {
                dil = 1,
                kanalKodu = 3,
                seferSorgulamaKriterWSDVO = new SeferSorgulamaKriter
                {
                    aktarmalarGelsin = true,
                    binisIstasyonId = Convert.ToInt64(Stations.Sivas),
                    binisIstasyonu = nameof(Stations.Sivas),
                    binisIstasyonu_isHaritaGosterimi = false,
                    bolgeselGelsin = true,
                    gidisTarih = "May 22, 2023 00:00:00 AM",
                    inisIstasyonId = Convert.ToInt64(Stations.AnkaraGar),
                    inisIstasyonu = nameof(Stations.AnkaraGar),
                    inisIstasyonu_isHaritaGosterimi = false,
                    islemTipi = 0,
                    yolcuSayisi = 1,
                    satisKanali = 3,
                    seyahatTuru = 1
                }
            };

            HttpClientProviderService httpClient = new HttpClientProviderService(requestProvider, logProvider);
            var data = await httpClient.PostRequestAsync<TicketResponseModel>("sefer/seferSorgula", model);
            if (data != null)
            {
                var list = data.seferSorgulamaSonucList.Where(r => r.trenTipi == "YHT").Select(r => new ExpeditionView()
                {
                    binisTarih = DateTime.Parse(r.binisTarih),
                    inisTarih = DateTime.Parse(r.inisTarih),
                    kalanSayi = r.vagonTipleriBosYerUcret.Sum(v => v.kalanSayi),
                    standartBiletFiyati = Convert.ToDecimal(r.vagonTipleriBosYerUcret.First().standartBiletFiyati),
                    trenAdi = r.trenAdi,
                    trenTipi = r.trenTipi,
                    vagonTip = r.vagonTipleriBosYerUcret.First().vagonTip
                }).ToList();

                list = list.Where(l => l.kalanSayi > 0).ToList();

                if (list.Count > 0)
                {
                    var dt = await ListToTable.CreateTableAsync(list);

                    var str = await DataTableToHtmlTable.CreateTableAsync(dt);

                    MailSenderService senderService = new MailSenderService(logProvider);

                    var TO = new Dictionary<string, string>
                {
                    { "Ufuk Güleç", "orhanufukgulec@gmail.com" }
                };

                    var resultMail = await mailProvider.SendAsync(await senderService.Create(new MailMessage()
                    {
                        Body = str,
                        FromMail = "oug505@gmail.com",
                        FromName = "TCDD",
                        Subject = "YHT Bilet Bilgisi",
                        To = TO
                    }));

                    return resultMail;
                }


            }
            return false;
            //var filters = get_filter(3, Convert.ToInt64(Stations.AnkaraGar), nameof(Stations.AnkaraGar), Convert.ToInt64(Stations.Sivas), nameof(Stations.Sivas));

            //var tickets = List<string>();

            //var dt = await ListToTable.CreateTableAsync(tickets);

            //var dtString = await DataTableToHtmlTable.CreateTableAsync(dt);

            //var email = new MimeMessage();

            //email.From.Add(new MailboxAddress("TcddHelper", "oug505@gmail.com"));
            //email.To.Add(new MailboxAddress("Ufuk Güleç", "orhanufukgulec@gmail.com"));

            //email.Subject = "Tren";
            //email.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            //{
            //    Text = dtString,
            //};

            //MailHelper.SendMail(email);
        }



        private List<TicketPostModel> get_filter(int kacGun, long binisIstasyonId, string binisIstasyon, long inisIstasyonId, string inisIstasyon)
        {
            List<TicketPostModel> list = new List<TicketPostModel>();

            foreach (var dateString in getDates(kacGun))
            {
                list.Add(new TicketPostModel()
                {
                    dil = 1,
                    kanalKodu = 3,
                    seferSorgulamaKriterWSDVO = new SeferSorgulamaKriter
                    {
                        aktarmalarGelsin = true,
                        binisIstasyonId = binisIstasyonId,
                        binisIstasyonu = binisIstasyon,
                        binisIstasyonu_isHaritaGosterimi = false,
                        bolgeselGelsin = true,
                        gidisTarih = dateString,
                        inisIstasyonId = inisIstasyonId,
                        inisIstasyonu = inisIstasyon,
                        inisIstasyonu_isHaritaGosterimi = false,
                        islemTipi = 0,
                        yolcuSayisi = 1,
                        satisKanali = 3,
                        seyahatTuru = 1
                    }
                });
            }
            return list;
        }

        private List<string> getDates(int c)
        {
            List<string> dates = new List<string>();

            var date = DateTime.Now;

            dates.Add(date.ToString("MMM d, yyyy") + " 00:00:00 AM");

            for (int i = 1; i < c + 1; i++)
            {
                dates.Add(date.AddDays(i).ToString("MMM d, yyyy") + " 00:00:00 AM");
            }

            return dates;
        }

    }
}

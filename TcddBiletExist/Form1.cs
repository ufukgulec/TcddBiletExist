using TcddBiletExist.Models;
using TcddBiletExist.Models.TicketModels;
using TcddBiletExist.Models.StationModels;
using TcddBiletExist.Providers;
using TcddBiletExist.Services.Concrete;

namespace TcddBiletExist
{
    public partial class Form1 : Form
    {
        private RequestProvider requestProvider = new RequestProvider();
        private LogProvider logProvider = new LogProvider();
        private LogProviderService logService = new LogProviderService();

        public Form1()
        {
            InitializeComponent();
            LogProvider.Default.OnLogAdded += (s, e) =>
            {
                AddLog(e);
            };
        }

        private void AddLog(string logMessage)
        {
            if (Logs.InvokeRequired)
            {
                Logs.Invoke(new Action(() => AddLog(logMessage)));
                return;
            }

            Logs.Items.Add(logMessage);

            Logs.SelectedIndex = Logs.Items.Count - 1;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            set_dateTimePicker();
            var stationResult = await bind_stationsAsync();
        }

        private void set_dateTimePicker()
        {
            DepartureDate.MinDate = DateTime.Now;
        }

        private async Task<bool> bind_stationsAsync()
        {
            HttpClientProviderService httpClient = new HttpClientProviderService(requestProvider, logProvider);

            var data = await httpClient.PostRequestAsync<StationResponseModel>("istasyon/istasyonYukle", new StationPostRequestModel()
            {
                Dil = 1,
                KanalKodu = 3,
                Tarih = null,
                SatisSorgu = true
            });

            if (data != null)
            {
                var bindingSourceFromCity = new BindingSource();
                bindingSourceFromCity.DataSource = data.IstasyonBilgileriList.GetRange(0, data.IstasyonBilgileriList.Count);

                FromCity.DataSource = bindingSourceFromCity.DataSource;

                FromCity.DisplayMember = "IstasyonAdi";
                FromCity.ValueMember = "IstasyonId";

                var bindingSourceToCity = new BindingSource();
                bindingSourceToCity.DataSource = data.IstasyonBilgileriList.GetRange(0, data.IstasyonBilgileriList.Count);

                ToCity.DataSource = bindingSourceToCity.DataSource;

                ToCity.DisplayMember = "IstasyonAdi";
                ToCity.ValueMember = "IstasyonId";


                var log = await logService.CreateAsync($"Ýstasyon Sayýsý : {data.IstasyonBilgileriList.Count}", LogType.Warning);
                LogProvider.Default.AddLog(log);

                return true;
            }
            else
            {
                var log = await logService.CreateAsync("Ýstasyon Bilgisi Yok", LogType.Warning);
                LogProvider.Default.AddLog(log);
                return false;
            }
        }

        private async void FindTicket_Click(object sender, EventArgs e)
        {
            await bind_ticketsAsync();
        }

        private async Task<bool> bind_ticketsAsync()
        {
            //Filter filter = new Filter()
            //{
            //    binisIstasyonuAdi = this.FromCity.GetItemText(this.FromCity.SelectedItem),
            //    inisIstasyonuAdi = this.ToCity.GetItemText(this.ToCity.SelectedItem),
            //    gidisTarih = this.DepartureDate.Value.ToString("MMM d, yyyy") + " 00:00:00 AM",
            //    yolcuSayisi = Convert.ToInt64(this.PassengerCount.Value),
            //    binisIstasyonuKod = Convert.ToInt64(this.FromCity.SelectedValue),
            //    inisIstasyonuKod = Convert.ToInt64(this.ToCity.SelectedValue)
            //};

            TicketPostModel model = new TicketPostModel()
            {
                dil = 1,
                kanalKodu = 3,
                seferSorgulamaKriterWSDVO = new SeferSorgulamaKriter
                {
                    aktarmalarGelsin = true,
                    binisIstasyonId = Convert.ToInt64(this.FromCity.SelectedValue),
                    binisIstasyonu = this.FromCity.GetItemText(this.FromCity.SelectedItem),
                    binisIstasyonu_isHaritaGosterimi = false,
                    bolgeselGelsin = true,
                    gidisTarih = this.DepartureDate.Value.ToString("MMM d, yyyy") + " 00:00:00 AM",
                    inisIstasyonId = Convert.ToInt64(this.ToCity.SelectedValue),
                    inisIstasyonu = this.ToCity.GetItemText(this.ToCity.SelectedItem),
                    inisIstasyonu_isHaritaGosterimi = false,
                    islemTipi = 0,
                    yolcuSayisi = Convert.ToInt64(this.PassengerCount.Value),
                    satisKanali = 3,
                    seyahatTuru = 1
                }
            };

            HttpClientProviderService httpClient = new HttpClientProviderService(requestProvider, logProvider);
            var data = await httpClient.PostRequestAsync<TicketResponseModel>("sefer/seferSorgula", model);

            expeditionViewBindingSource.Clear();

            if (data != null && data.seferSorgulamaSonucList != null)
            {
                var select = data.seferSorgulamaSonucList.Select(d => new ExpeditionView()
                {
                    trenAdi = d.trenAdi,
                    trenTipi = d.trenTipi,
                    binisTarih = DateTime.Parse(d.binisTarih),
                    inisTarih = DateTime.Parse(d.inisTarih),
                    kalanSayi = d.vagonTipleriBosYerUcret.Sum(r => r.kalanSayi),
                    standartBiletFiyati = d.vagonTipleriBosYerUcret.Average(r => Convert.ToDecimal(r.standartBiletFiyati)),
                    vagonTip = d.vagonTipleriBosYerUcret.First().vagonTip
                }).ToList();

                foreach (var item in select)
                {
                    expeditionViewBindingSource.Add(item);

                }

                var log = await logService.CreateAsync($"Ýstasyon Sayýsý : {select.Count}", LogType.Warning);
                LogProvider.Default.AddLog(log);

                return true;
            }
            else
            {
                var log = await logService.CreateAsync("Bilet Bilgisi Yok", LogType.Warning);
                LogProvider.Default.AddLog(log);
                return false;
            }
        }
    }
}
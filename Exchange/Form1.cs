using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Exchange
{

    public partial class Form1 : Form
    {
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>();
        List<Root> DataList = new List<Root>();
        public Form1()
        {
            InitializeComponent();
            exchangeRates.Add("PLNPLN", 1.0);
            exchangeRates.Add("USDPLN", 3);
            exchangeRates.Add("EURPLN", 4);
            exchangeRates.Add("RUBPLN", 0.0418);
            exchangeRates.Add("THBPLN", 0.1165);
        }

        private void Calculate(object sender, EventArgs e)
        {
            //default
            string from = "PLN";
            if (SPLN.Checked)
            {
                from = "PLN";
            }
            if (SUSD.Checked)
            {
                from = "USD";
            }
            else if (SEUR.Checked)
            {
                from = "EUR";
            }
            else if (SRUB.Checked)
            {
                from = "RUB";
            }
            else if (STHB.Checked)
            {
                from = "THB";
            }
            from += "PLN";
            double amountInPLN = (double)amountNumeric.Value * exchangeRates[from];
            //default
            string result = string.Empty;
            if (TPLN.Checked)
            {
                result = Math.Round(amountInPLN, 2) + " PLN";
            }
            else if (TUSD.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["USDPLN"], 2) + " USD";
            }
            else if (TEUR.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["EURPLN"], 2) + " EUR";
            }
            else if (TRUB.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["RUBPLN"], 2) + " RUB";
            }
            else if (TTHB.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["THBPLN"], 2) + " THB";
            }
            ResultLabel.Text = result.ToString();
        }
        public void GetRatesFromAPI()
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://api.nbp.pl/api/exchangerates/tables/A/?format=json").Result;
            var content = response.Content.ReadAsStringAsync().Result;
            DataList = JsonConvert.DeserializeObject<List<Root>>(content) ?? DataList;
        }

        private void APIButtonClicked(object sender, EventArgs e)
        {
            GetRatesFromAPI();
            foreach(Rate r in DataList[0].Rates)
            {
                if(r.code == "USD")
                {
                    exchangeRates["USDPLN"] = r.mid;
                }
                else if (r.code == "EUR")
                {
                    exchangeRates["EURPLN"] = r.mid;
                }
                else if (r.code == "RUB")
                {
                    exchangeRates["RUBPLN"] = r.mid;
                }
                else if (r.code == "THB")
                {
                    exchangeRates["THBPLN"] = r.mid;
                }
            }
            Button b = (Button)sender;
            b.Text = "Pobrane!";
        }
    }
}

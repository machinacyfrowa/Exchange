namespace Exchange
{

    public partial class Form1 : Form
    {
        Dictionary<string, double> exchangeRates = new Dictionary<string, double>();
        public Form1()
        {
            InitializeComponent();
            exchangeRates.Add("PLNPLN", 1.0);
            exchangeRates.Add("USDPLN", 3.8300);
            exchangeRates.Add("EURPLN", 4.2668);
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
            else if(SEUR.Checked)
            {
                from = "EUR";
            }
            else if(SRUB.Checked)
            {
                from = "RUB";
            }
            else if(STHB.Checked)
            {
                from = "THB";
            }
            from += "PLN";
            double amountInPLN = (double)amountNumeric.Value * exchangeRates[from];
            //default
            string result = string.Empty;
            if(TPLN.Checked)
            {
                result = Math.Round(amountInPLN, 2) + " PLN";
            }
            else if(TUSD.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["USDPLN"], 2) + " USD";
            }
            else if(TEUR.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["EURPLN"], 2) + " EUR";
            }
            else if(TRUB.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["RUBPLN"], 2) + " RUB";
            }
            else if(TTHB.Checked)
            {
                result = Math.Round(amountInPLN / exchangeRates["THBPLN"], 2) + " THB";
            }   
            ResultLabel.Text = result.ToString() ;
        }
    }
}

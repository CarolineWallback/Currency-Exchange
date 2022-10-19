namespace Exchange_Rate
{
    public class ExchangeRate
    {
        private bool success;
        private int timestamp;
        private string Base;
        private string date;
        public Rates rates;

        public ExchangeRate(bool success, int timestamp, string Base, string date, Rates rates)
        {
            this.success = success;
            this.timestamp = timestamp;
            this.Base = Base;
            this.date = date;
            this.rates = rates;
        }
        public ExchangeRate()
        {

        }
    }
}

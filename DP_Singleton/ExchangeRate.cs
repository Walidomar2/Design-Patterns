namespace DP_Singleton
{
    internal class ExchangeRate
    {
        public string TargetCurrency { get;  }
        public string BaseCurrency { get;  }
        public decimal Rate { get; }

        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
        {
            BaseCurrency = baseCurrency;
            TargetCurrency = targetCurrency;
            Rate = rate;
        }
    }
}

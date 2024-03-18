namespace DP_Singleton
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter Base Currency: ");
                var baseCurrency = Console.ReadLine(); 

                Console.Write("Enter Target Currency: ");
                var targetCurrency = Console.ReadLine();

                Console.Write("Enter amount: ");
                var amount = decimal.Parse(Console.ReadLine());

                var exchangedAmount = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount);

                Console.WriteLine($"{amount} {baseCurrency} = {exchangedAmount} {targetCurrency}");
                Console.WriteLine("\n-------------------------------------------------\n");

            }
        }
    }
}
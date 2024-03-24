namespace DP_Strategy.DiscountStrategies
{
    public class SilverCustomerDiscountStrategy : ICustomerStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice >= 10000 ? 0.1 : 0;
        }
    }
}

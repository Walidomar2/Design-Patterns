namespace DP_Strategy.DiscountStrategies
{
    public class GoldCustomerDiscountStrategy : ICustomerStrategy
    {
        public double CalculateDiscount(double totalPrice)
        {
            return totalPrice>= 10000 ? 0.2 : 0;
        }
    }
}

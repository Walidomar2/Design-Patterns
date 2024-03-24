namespace DP_Strategy
{
    public class Invoice
    {
        public Customer Customer { get; set; }
        public List<InvoiceLine> Lines { get; set; }
        public double TotalPrice => Lines.Sum(x => x.Quantity * x.UnitPrice);

        public double DiscountPercentage {  get; set; }
        public double NetPrice => TotalPrice - (TotalPrice * DiscountPercentage);
    }
}

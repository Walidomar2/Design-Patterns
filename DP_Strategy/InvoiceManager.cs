using DP_Strategy.DiscountStrategies;
using System.Diagnostics;

namespace DP_Strategy
{
    public class InvoiceManager
    {
        private ICustomerStrategy _customerStrategy;

        public void SetDiscoundStrategy(ICustomerStrategy customerStrategy)
        {
            _customerStrategy = customerStrategy;
        }

        public Invoice CreateInvoice(Customer customer,int quantity,double price)
        {

            var invoice = new Invoice
            {
                Customer = customer,
                Lines = new List<InvoiceLine>
                {
                        new InvoiceLine { Quantity = quantity, UnitPrice = price }
                    }
            };
            invoice.DiscountPercentage = _customerStrategy.CalculateDiscount(invoice.TotalPrice);
            return invoice;
        }
    }
}

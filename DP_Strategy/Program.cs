using DP_Strategy.DiscountStrategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP_Strategy
{
    class Program
    {
        static void Main()
        {
            var dataReader = new CustomerDataReader();
            var customers = dataReader.GetCustomers();

            while (true)
            {
                Console.Write("Enter Customer ID: ");
                var customerId = int.Parse(Console.ReadLine());

                Console.Write("Enter Item Quantity: ");
                var quantity = int.Parse(Console.ReadLine());

                Console.Write("Enter Unit Price: ");
                var price = double.Parse(Console.ReadLine());

                var customer = customers.First(x => x.Id == customerId);

                ICustomerStrategy CustomerDiscountStrategy = default!;

                if (customer.Category == CustomerCategories.New)
                  CustomerDiscountStrategy = new NewCustomerDiscountStrategy();

                else if(customer.Category == CustomerCategories.Silver)
                    CustomerDiscountStrategy = new SilverCustomerDiscountStrategy();

                else if(customer.Category == CustomerCategories.Gold)
                    CustomerDiscountStrategy = new GoldCustomerDiscountStrategy();

                var invoiceManager = new InvoiceManager();

                invoiceManager.SetDiscoundStrategy(CustomerDiscountStrategy);

               var invoice = invoiceManager.CreateInvoice(customer, quantity, price);

                Console.WriteLine($"Invouce Created for Cusomter {customer.Name} with Net price {invoice.NetPrice}");
                Console.WriteLine("\n----------------------------------------------\n ");

            }
        }
    }
}
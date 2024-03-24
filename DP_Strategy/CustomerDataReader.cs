namespace DP_Strategy
{
    public class CustomerDataReader
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    Id = 1,
                    Name = "Walid Omar",
                    Category = CustomerCategories.Gold
                },
                new Customer
                {
                    Id = 2,
                    Name = "Karem Omar",
                    Category = CustomerCategories.Silver
                },
                new Customer
                {
                    Id = 3,
                    Name = "Mohamed Omar",
                    Category = CustomerCategories.New
                }
            };
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace NetCoreApp.Data
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Customer()
        {
            this.Orders = new HashSet<Order>();
        }
    }
}
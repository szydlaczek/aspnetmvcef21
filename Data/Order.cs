using System;

namespace NetCoreApp.Data
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public OrderStatus Status { get; set; }
    }
}
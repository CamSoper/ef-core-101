using System;
using System.Collections.Generic;
namespace ContosoPets.Ui.Models
{

    public class Order
    {
        public Order()
        {
            Id = Guid.NewGuid();
            ProductOrders = new HashSet<ProductOrder>();
        }

        public Guid Id { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public Guid CustomerId { get; set; }

        public Customer Customer { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
    }

}
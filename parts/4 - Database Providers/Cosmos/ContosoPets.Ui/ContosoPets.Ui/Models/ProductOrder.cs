using System;

namespace ContosoPets.Ui.Models
{
    public class ProductOrder
    {
        public ProductOrder()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public int Quantity { get; set; }
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }

        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
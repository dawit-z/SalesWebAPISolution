using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesWebAPI.Models
{
    public class Order
    {
        public int Id { get; set; }

        [Required, MaxLength(80)]
        public string Description { get; set; }

        
        public bool Shipped { get; set; }

        [Required, Column(TypeName = "decimal(7,2)")]
        public decimal Total { get; set; }

        
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        public virtual List<Orderline> Orderlines { get; set; } = new List<Orderline>();

        public Order(){}
    }
}
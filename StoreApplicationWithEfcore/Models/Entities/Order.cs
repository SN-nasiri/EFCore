using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Entities
{
    public class Order
    {
        public long Id { get; set; }
        public DateTime CreateDate { get; set; }
        public string Address { get; set; }

        public virtual Customer Customer { get; set; }
        public long CustomerId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

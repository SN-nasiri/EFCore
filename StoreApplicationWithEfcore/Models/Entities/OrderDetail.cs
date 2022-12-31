using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Entities
{
    public class OrderDetail
    {
        public long Id { get; set; }
        public int Count { get; set; }

        public virtual Order Order { get; set; }
        public long OderId { get; set; }
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

    }
}

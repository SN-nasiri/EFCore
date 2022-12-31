using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Images { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
        public byte Ram { get; set; }
        public OStype OS { get; set; }
        public float Resolation { get; set; }
        public string Network { get; set; }
        public int Inventory { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Warranty Warranty { get; set; }
    }

    public enum OStype
    {
        IOS = 0,
        Android = 1,
        WindowsPhone = 2,
    }
}

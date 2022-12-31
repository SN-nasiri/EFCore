using StoreApplicationWithEfcore.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Entities
{
    public class Warranty
    {
        public Product Product { get; set; }
        public long ProductId { get; set; }
        public int WarrantyPeriod { get; set; }
    }
}

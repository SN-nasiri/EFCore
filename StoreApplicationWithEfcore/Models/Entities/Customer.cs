using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Entities
{
    public class Customer
    {
        public long Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }

        //یک مشتری میتواند چندین سفارش داشته باشد
        public virtual ICollection<Order>Orders { get; set; }
    }
}

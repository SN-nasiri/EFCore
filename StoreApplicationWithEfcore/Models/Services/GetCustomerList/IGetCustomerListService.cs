using StoreApplicationWithEfcore.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplicationWithEfcore.Models.Services.GetCustomerList
{
    public interface IGetCustomerListService
    {
        List<CustomerListDto> Execute();
    }


    public class GetCustomerListService : IGetCustomerListService
    {
        private readonly DatabaseContext context;

        public GetCustomerListService()
        {
            context = new DatabaseContext();
        }

        public List<CustomerListDto> Execute()
        {
            var customers = context.Customers.Select(p => new CustomerListDto
            {
                Id = p.Id,
                Name = p.Name,
                UserName = p.UserName,
            }).ToList();
            return customers;
        }
    }

    public class CustomerListDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public string UserName { get; set; }
    }
}

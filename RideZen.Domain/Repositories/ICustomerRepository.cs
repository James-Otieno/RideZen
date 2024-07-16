using RideZen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Repositories
{
   public interface ICustomerRepository
    {


        Task<bool>SaveCustomerAsync(Customer customer);
        Task<Customer> GetCustomerByIdAsync(Guid customerId);
        Task<IEnumerable<Customer>> GetAllCustomersAsync();
        Task<bool> UpdateCustomerAsync(Customer customer);
        Task<bool> DeleteCustomerAsync(Guid customerId);
    }
}

using Microsoft.EntityFrameworkCore;
using RideZen.Domain.Entities;
using RideZen.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Infrastructure.Persistence
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly RideZenContext _rideZenContext;

        public CustomerRepository(RideZenContext rideZenContext)
        {
            _rideZenContext = rideZenContext ?? throw new ArgumentNullException(nameof(rideZenContext));


        }


        public async Task<bool> DeleteCustomerAsync(Guid customerId)
        {
            try
            {
                var customer = await _rideZenContext.Customers.FindAsync(customerId);
                if (customer == null)
                {
                    return false;
                }

                _rideZenContext.Customers.Remove(customer);
                return await _rideZenContext.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _rideZenContext.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid customerId)
        {
            return await _rideZenContext.Customers.FindAsync(customerId);
        }

        public async Task<bool> SaveCustomerAsync(Customer customer)
        {
            await _rideZenContext.Customers.AddAsync(customer);
            return await _rideZenContext.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateCustomerAsync(Customer customer)
        {
            _rideZenContext.Customers.Update(customer);
            return await _rideZenContext.SaveChangesAsync() > 0;
        }
    }
}

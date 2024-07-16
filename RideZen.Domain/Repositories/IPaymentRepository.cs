using RideZen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Repositories
{
   public interface IPaymentRepository
    {

        Task<Payment> GetPaymentByIdAsync(Guid paymentId);
        Task<IEnumerable<Payment>> GetAllPaymentsAsync();
        Task<IEnumerable<Payment>> GetPaymentsByCustomerIdAsync(Guid customerId);
        Task<IEnumerable<Payment>> GetPaymentsByDriverIdAsync(Guid driverId);
        Task<bool> SavePaymentAsync(Payment payment);
        Task<bool> UpdatePaymentAsync(Payment payment);
        Task<bool> DeletePaymentAsync(Guid paymentId);

    }
}

using RideZen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Repositories
{
    public interface IRideRepository
    {

        Task<Ride> GetRideByIdAsync(Guid rideId);
        Task<IEnumerable<Ride>> GetAllRidesAsync();
        Task<IEnumerable<Ride>> GetRidesByCustomerIdAsync(Guid customerId);
        Task<IEnumerable<Ride>> GetRidesByDriverIdAsync(Guid driverId);
        Task<bool> SaveRideAsync(Ride ride);
        Task<bool> UpdateRideAsync(Ride ride);
        Task<bool> DeleteRideAsync(Guid rideId);
    }
}

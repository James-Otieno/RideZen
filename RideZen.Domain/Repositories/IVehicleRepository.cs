using RideZen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Repositories
{
    public interface IVehicleRepository
    {

        Task<Vehicle> GetVehicleByIdAsync(Guid vehicleId);
        Task<IEnumerable<Vehicle>> GetAllVehiclesAsync();
        Task<IEnumerable<Vehicle>> GetVehiclesByDriverIdAsync(Guid driverId);
        Task<bool> SaveVehicleAsync(Vehicle vehicle);
        Task<bool> UpdateVehicleAsync(Vehicle vehicle);
        Task<bool> DeleteVehicleAsync(Guid vehicleId);
    }
}

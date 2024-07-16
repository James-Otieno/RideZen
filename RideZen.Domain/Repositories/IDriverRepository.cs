using RideZen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Repositories
{
    public interface IDriverRepository
    {
        Task<bool> SaveDriverAsync(Driver driver);
        Task<Driver> GetDriverByIdAsync(Guid driverId);
        Task<IEnumerable<Driver>> GetAllDriversAsync();
        Task<bool> UpdateDriverAsync(Driver driver);
        Task<bool> DeleteDriverAsync(Guid driverId);
    }
}
}

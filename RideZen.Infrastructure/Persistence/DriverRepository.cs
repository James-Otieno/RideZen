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
    public class DriverRepository : IDriverRepository
    {


        private readonly RideZenContext _rideZenContext;

        public DriverRepository(RideZenContext rideZenContext)
        {
            _rideZenContext = rideZenContext ?? throw new ArgumentNullException(nameof(rideZenContext));

        }

        public async Task<bool> DeleteDriverAsync(Guid driverId)
        {
            try
            {
                var driver = await _rideZenContext.Drivers.FindAsync(driverId);
                if (driver == null)
                {
                    return false;
                }

                _rideZenContext.Drivers.Remove(driver);
                return await _rideZenContext.SaveChangesAsync() > 0;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<Driver>> GetAllDriversAsync()
        {
            try
            {
                return await _rideZenContext.Drivers.ToListAsync();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Driver> GetDriverByIdAsync(Guid driverId)
        {
            try
            {
                return await _rideZenContext.Drivers.FindAsync(driverId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> SaveDriverAsync(Driver driver)
        {
            try
            {
                await _rideZenContext.Drivers.AddAsync(driver);
                return await _rideZenContext.SaveChangesAsync() > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateDriverAsync(Driver driver)
        {
            try
            {
                _rideZenContext.Drivers.Update(driver);
                return await _rideZenContext.SaveChangesAsync() > 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

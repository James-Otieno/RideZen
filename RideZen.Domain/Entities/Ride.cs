using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Entities
{
    public class Ride
    {
       
        public Guid RideId { get; set; }

        [Required]
        public Guid CustomerId { get; set; }

        [Required]
        public Guid DriverId { get; set; }

        [Required]
        public DateTime RequestTime { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        [Required]
        [StringLength(255)]
        public string PickupLocation { get; set; }

        [Required]
        [StringLength(255)]
        public string DropoffLocation { get; set; }

        public decimal Distance { get; set; }

        public decimal Fare { get; set; }

        public decimal WaitingTime { get; set; }

        public RideStatus Status { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public Driver Driver { get; set; }

        public Ride() { }

        public Ride(Guid rideId,Guid driverId,Guid customerId, DateTime requestTime, string pickupLocation, string dropoffLocation,Decimal distance)
        {
            DriverId = driverId;
            CustomerId = customerId;
            DriverId = driverId;
            RequestTime = requestTime;
            PickupLocation = pickupLocation;
            DropoffLocation = dropoffLocation;
            Distance = distance;
            Status = RideStatus.Requested;
        
        }

        public enum RideStatus
        {
            Requested,
            Accepted,
            InProgress,
            Completed,
            Cancelled
        }

        public static Ride AddNewRide(Guid rideId, Guid driverId, Guid customerId, DateTime requestTime, string pickupLocation, string dropoffLocation, Decimal distance)
        {
            return new Ride(rideId, driverId,customerId, requestTime, pickupLocation, dropoffLocation,distance);
        }
    }
}

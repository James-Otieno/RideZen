using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Entities
{
  public class Vehicle
    {

        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Make { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        [Required]
        [StringLength(50)]
        public string LicensePlate { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public string VehiclePicture { get; set; }

        public Vehicle() {}

        public Vehicle(string make, string model, string licensePlate, int year, string color, string vehiclePicture)
        {
            Id = Guid.NewGuid();
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
            Year = year;
            Color = color;
            VehiclePicture = vehiclePicture;

        }
        public static Vehicle AddNewVehicle(string make, string model, string licensePlate, int year, string color, string vehiclePicture)
        {
            return new Vehicle( make,  model, licensePlate, year, color,  vehiclePicture);
        }
    }
}

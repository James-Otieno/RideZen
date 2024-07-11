using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Entities
{
    public class Driver
    {
        public Guid DriverId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
        public string AltPhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string IdNumber { get; set; }

        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        public string ProfilePicture { get; set; }

        public string LicenseNumber { get; set; }

        public DateTime LicenseExpiryDate { get; set; }

        public Vehicle Vehicle { get; set; }

        public Driver(string name, string email,string idNumber, string password, string phoneNumber, string profilePicture, string licenseNumber, DateTime licenseExpiryDate, Vehicle vehicle)
        {
            DriverId = Guid.NewGuid();
            Name = name;
            Email = email;
            IdNumber = idNumber;
            Password = password;
            PhoneNumber = phoneNumber;
            ProfilePicture = profilePicture;
            LicenseNumber = licenseNumber;
            LicenseExpiryDate = licenseExpiryDate;
            Vehicle = vehicle;
                
        }

        public static Driver AddNewDriver(string name, string email,string idNumber, string password, string phoneNumber, string profilePicture, string licenseNumber, DateTime licenseExpiryDate, Vehicle vehicle)
        {
            return new Driver(name, email, idNumber, password, phoneNumber, profilePicture, licenseNumber,  licenseExpiryDate, vehicle); 
        }


    }
}

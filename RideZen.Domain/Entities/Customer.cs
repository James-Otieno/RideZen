using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Entities
{
    public class Customer
    {
        
        public Guid Id { get; set; }

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


        public Customer() { }

        public Customer(string name, string email, string password, string phoneNumber, string profilePicture, string idNumber)
        {
            Name = name;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
            ProfilePicture = profilePicture;
            IdNumber = idNumber;

        }

        public static Customer AddNewCustomer(string name, string email, string password, string phoneNumber, string profilePicture, string idNumber)
        {
            return new Customer(name, email, password, phoneNumber, profilePicture, idNumber);
                
        }


    }

}

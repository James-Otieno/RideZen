using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RideZen.Domain.Entities
{
    public class Payment
    {

        
        public Guid PaymentId { get; set; }

        [Required]
        public Guid RideId { get; set; }

        [ForeignKey("RideId")]
        public Ride Ride { get; set; }

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public PaymentStatus Status { get; set; }

        [Required]
        public DateTime TransactionDate { get; set; }

        [Required]
        [StringLength(100)]
        public string MpesaTransactionId { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        // Default constructor
        public Payment()
        {
           
        }

        public Payment(Guid rideId, decimal amount, PaymentStatus status, DateTime transactionDate, string mpesaTransactionId, string description = null)
        {
            PaymentId =Guid.NewGuid();
            RideId = rideId;
            Amount = amount;
            Status = status;
            TransactionDate = transactionDate;
            MpesaTransactionId = mpesaTransactionId;
            Description = description;
        }
        public static Payment CreateNewPayment(Guid rideId, decimal amount, string mpesaTransactionId, string description = null)
        {
            return new Payment(rideId, amount, PaymentStatus.Completed, DateTime.Now, mpesaTransactionId, description); 
        }
    }
              public enum PaymentStatus
              {
                  Pending,
                  Completed,
                   Failed
    }


}

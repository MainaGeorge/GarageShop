﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GarageShop.Models
{
    public class PaymentDetails
    {
        [Key]
        public int Id { get; set; }

        public string CustomerId { get; set; }

        public string TransactionId { get; set; }

        public string Description { get; set; }

        public string Currency { get; set; }

        [Required]
        public long? Amount { get; set; }

        [ForeignKey("CustomerId")]
        public ApplicationUser ApplicationUser { get; set; }

        
    }
}

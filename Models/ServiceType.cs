using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GarageShop.Models
{
    public class ServiceType
    {
        public int Id { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

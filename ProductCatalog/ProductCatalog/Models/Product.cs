using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [StringLength(50)]
        [Display(Name="Short description (optional)")]
        public string Description { get; set; }
        [Required]
        [Range(0, 1000, ErrorMessage ="Quantity cannot be less than zero.")]
        [Display(Name="Quantity available")]
        public int Quantity { get; set; }
    }
}

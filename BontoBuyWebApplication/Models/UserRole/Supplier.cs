using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BontoBuyWebApplication.Models.UserRole
{
    [Table("Supplier")]
    public class Supplier : User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SupplierId { get; set; }

        [Required]
        [StringLength(100,MinimumLength=6)]
        [Display(Name="Organization Name")]
        public string SupplierName { get; set; }

        [Required]
        [Display(Name="Street")]
        public string Street { get; set; }

        [Display(Name="Website")]
        public string Website { get; set; }

        [Display(Name="Status")]
        public string Status { get; set; }

        [Required]
        [Display(Name="City")]
        public string City { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }


    }
}
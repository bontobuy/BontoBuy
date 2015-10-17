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
        public string SupplierName { get; set; }
        public string Street { get; set; }
        public int PhoneNumber { get; set; }
        public string Website { get; set; }
        public string Status { get; set; }
        public string City { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }


    }
}
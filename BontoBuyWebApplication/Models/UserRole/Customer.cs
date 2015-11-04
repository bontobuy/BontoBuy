using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BontoBuyWebApplication.Models.UserRole
{
    [Table("Customer")]
    public class Customer:User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public string City { get; set; }

        public string FirstName { get; set; }

        public string  LastName { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateCreated { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateOfBirth { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateUpdated { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string Street { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BontoBuyWebApplication.Models.UserRole
{
    [Table("Admin")]
    public class Admin:User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminId { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 6)]
        [Display(Name = "Admin Name")]
        public string AdminName { get; set; }
    }
}
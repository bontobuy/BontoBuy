using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using BontoBuyWebApplication.Models.UserRole;

namespace BontoBuyWebApplication.Models.ProductType
{
    public class Product
    {
        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public string  ProductName { get; set; }
        public int Price { get; set; }
       
        public Supplier Supplier { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateCreated { get; set; }

        [Column(TypeName = "DateTime2")]
        public Nullable<DateTime> DateUpdated { get; set; }

       
      
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Product")]
    public class Product
        {
            public int Id { get; set; }
            public string ProductName { get; set; }
            public decimal UnitPrice { get; set; }
            public string Package { get; set; }
            public int SupplierId { get; set; }
        }
}
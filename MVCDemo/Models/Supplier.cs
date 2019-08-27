using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Supplier")]
    public class Supplier
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public List<Product> Products { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProducts.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public double Rate { get; set; }
    }
}
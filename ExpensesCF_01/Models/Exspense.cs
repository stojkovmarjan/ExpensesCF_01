using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExpensesCF_01.Models
{
    public class Exspense
    {
        public int Id { get; set; }
        public decimal Quantity {get;set;}
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public Product Product { get; set; }
    }
}
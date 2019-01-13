using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExpensesCF_01.Models
{
    public class Exspense
    {
        public int Id { get; set; }

        [Required]
        public decimal Quantity {get;set;}

        [Required]
        public decimal Total { get; set; }

        public Product Product { get; set; }
    }
}
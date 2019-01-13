using ExpensesCF_01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ExpensesCF_01.DAL
{
    public class ExpensesContext: DbContext
    {
        public ExpensesContext() : base("name=ExpensesConn") { }

        public DbSet<Product> Product { get; set; }
        public DbSet<Exspense> Expense { get; set; }
    }
}
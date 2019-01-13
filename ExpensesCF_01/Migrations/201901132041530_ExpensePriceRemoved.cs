namespace ExpensesCF_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExpensePriceRemoved : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Exspenses", "Price");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Exspenses", "Price", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}

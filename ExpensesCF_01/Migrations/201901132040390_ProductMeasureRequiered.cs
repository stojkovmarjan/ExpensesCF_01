namespace ExpensesCF_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProductMeasureRequiered : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Measure", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Measure", c => c.String());
        }
    }
}

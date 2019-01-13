namespace ExpensesCF_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MeasureMinMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Measure", c => c.String(nullable: false, maxLength: 8));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Measure", c => c.String(nullable: false));
        }
    }
}

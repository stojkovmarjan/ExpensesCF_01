namespace ExpensesCF_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigrationForSql : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products VALUES('Леб','бр')");
            Sql("INSERT INTO Products VALUES('Млеко','л')");
            Sql("INSERT INTO Products VALUES('Бензин','л')");
            
        }
        
        public override void Down()
        {
        }
    }
}

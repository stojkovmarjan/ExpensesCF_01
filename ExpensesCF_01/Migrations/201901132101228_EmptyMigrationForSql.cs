namespace ExpensesCF_01.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmptyMigrationForSql : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products VALUES('���','��')");
            Sql("INSERT INTO Products VALUES('�����','�')");
            Sql("INSERT INTO Products VALUES('������','�')");
            
        }
        
        public override void Down()
        {
        }
    }
}

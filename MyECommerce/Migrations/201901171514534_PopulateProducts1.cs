namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProducts1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES ('Apple AirPods', 'Wireless earphones from Apple', 1596, 3)");
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES ('Samsung Gear Icon', 'Wireless earphones from Samsung', 857, 3)");
        }

        public override void Down()
        {
        }
    }
}

namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES ('MSI Titan', 'GT73VR 7RE', 19000, 1)");
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES (Surface Notebook', 'i7 Geforce 1080 16GB Ram', 15700, 1)");
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES ('IPhone 8', 'Apple Iphone 8 64GB', 6438, 2)");
            Sql("INSERT INTO Products (Name, Description, Price, Category_Id) VALUES ('S8', 'Samsung Galaxy S8', 4350, 2)");

        }
        
        public override void Down()
        {
        }
    }
}

using System.Diagnostics;

namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductCategories (Id, Name) VALUES (1, 'Datorer')");
            Sql("INSERT INTO ProductCategories (Id, Name) VALUES (2, 'Telefoner')");
            Sql("INSERT INTO ProductCategories (Id, Name) VALUES (3, 'Ljud & Bild')");
        }
        
        public override void Down()
        {
        }
    }
}

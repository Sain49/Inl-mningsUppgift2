namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategoryId : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ProductCategories");
            AlterColumn("dbo.ProductCategories", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ProductCategories", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ProductCategories");
            AlterColumn("dbo.ProductCategories", "Id", c => c.Byte(nullable: false));
            AddPrimaryKey("dbo.ProductCategories", "Id");
        }
    }
}

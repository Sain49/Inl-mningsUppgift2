namespace MyECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateProductCategoryId1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Category_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Category_Id", c => c.Byte(nullable: false));
        }
    }
}

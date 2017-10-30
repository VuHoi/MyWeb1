namespace MyWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Products : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Detail = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.products");
        }
    }
}

namespace BilligaVitvaror.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Items",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        TitleName = c.String(),
                        Weight = c.Double(nullable: false),
                        Volume = c.Double(nullable: false),
                        Price = c.Double(nullable: false),
                        Producer_ProducerId = c.Int(),
                    })
                .PrimaryKey(t => t.ItemId)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Producers", t => t.Producer_ProducerId)
                .Index(t => t.CategoryId)
                .Index(t => t.Producer_ProducerId);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        ProducerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ProducerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Producer_ProducerId", "dbo.Producers");
            DropForeignKey("dbo.Items", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Items", new[] { "Producer_ProducerId" });
            DropIndex("dbo.Items", new[] { "CategoryId" });
            DropTable("dbo.Producers");
            DropTable("dbo.Items");
            DropTable("dbo.Categories");
        }
    }
}

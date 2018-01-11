namespace FHHC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddClientmodeltodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientsModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateStarted = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PCWsModelsClientsModels",
                c => new
                    {
                        PCWsModels_Id = c.Int(nullable: false),
                        ClientsModels_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PCWsModels_Id, t.ClientsModels_Id })
                .ForeignKey("dbo.PCWsModels", t => t.PCWsModels_Id, cascadeDelete: true)
                .ForeignKey("dbo.ClientsModels", t => t.ClientsModels_Id, cascadeDelete: true)
                .Index(t => t.PCWsModels_Id)
                .Index(t => t.ClientsModels_Id);
            
            AddColumn("dbo.AddressModels", "ClientsModels_Id", c => c.Int());
            CreateIndex("dbo.AddressModels", "ClientsModels_Id");
            AddForeignKey("dbo.AddressModels", "ClientsModels_Id", "dbo.ClientsModels", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PCWsModelsClientsModels", "ClientsModels_Id", "dbo.ClientsModels");
            DropForeignKey("dbo.PCWsModelsClientsModels", "PCWsModels_Id", "dbo.PCWsModels");
            DropForeignKey("dbo.AddressModels", "ClientsModels_Id", "dbo.ClientsModels");
            DropIndex("dbo.PCWsModelsClientsModels", new[] { "ClientsModels_Id" });
            DropIndex("dbo.PCWsModelsClientsModels", new[] { "PCWsModels_Id" });
            DropIndex("dbo.AddressModels", new[] { "ClientsModels_Id" });
            DropColumn("dbo.AddressModels", "ClientsModels_Id");
            DropTable("dbo.PCWsModelsClientsModels");
            DropTable("dbo.ClientsModels");
        }
    }
}

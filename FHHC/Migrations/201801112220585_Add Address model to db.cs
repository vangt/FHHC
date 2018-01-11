namespace FHHC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAddressmodeltodb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddressModels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Address = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Zip = c.String(),
                        PCWsModels_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PCWsModels", t => t.PCWsModels_Id)
                .Index(t => t.PCWsModels_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AddressModels", "PCWsModels_Id", "dbo.PCWsModels");
            DropIndex("dbo.AddressModels", new[] { "PCWsModels_Id" });
            DropTable("dbo.AddressModels");
        }
    }
}

namespace FHHC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedPCWfields : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PCWsModels", "FirstName", c => c.String());
            AddColumn("dbo.PCWsModels", "LastName", c => c.String());
            AddColumn("dbo.PCWsModels", "PhoneNumber", c => c.String());
            AddColumn("dbo.PCWsModels", "Email", c => c.String());
            DropColumn("dbo.PCWsModels", "FirstCheck");
            DropColumn("dbo.PCWsModels", "LastCheck");
            DropColumn("dbo.PCWsModels", "NextCheck");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PCWsModels", "NextCheck", c => c.DateTime());
            AddColumn("dbo.PCWsModels", "LastCheck", c => c.DateTime());
            AddColumn("dbo.PCWsModels", "FirstCheck", c => c.DateTime());
            DropColumn("dbo.PCWsModels", "Email");
            DropColumn("dbo.PCWsModels", "PhoneNumber");
            DropColumn("dbo.PCWsModels", "LastName");
            DropColumn("dbo.PCWsModels", "FirstName");
        }
    }
}

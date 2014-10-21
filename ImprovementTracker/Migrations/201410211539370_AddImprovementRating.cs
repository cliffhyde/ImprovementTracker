namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImprovementRating : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Improvements", "Rating", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Improvements", "Rating");
        }
    }
}

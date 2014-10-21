namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImprovementRating2 : DbMigration
    {
        public override void Up()
        {
            //AlterColumn("dbo.Improvements", "Rating", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Improvements", "Rating", c => c.Int(nullable: false));
        }
    }
}

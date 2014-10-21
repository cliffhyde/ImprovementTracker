namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImprovementDesc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Improvements", "Description", c => c.String(maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Improvements", "Description", c => c.String());
        }
    }
}

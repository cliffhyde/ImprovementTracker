namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendCommentsText : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false, maxLength: 50));
        }
    }
}

namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShrinkCommentsText : DbMigration
    {
        public override void Up()
        {
            Sql("Update comments Set commenttext=LEFT(commenttext,40)");
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "CommentText", c => c.String(nullable: false, maxLength: 500));
        }
    }
}


namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddComments : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentText = c.String(nullable: false, maxLength: 50),
                        CreatedBy = c.String(nullable: false),
                        CreatedOn = c.DateTime(nullable: false, defaultValueSql: "GetUtcdate()"),
                        ImprovementId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Improvements", t => t.ImprovementId, cascadeDelete: true)
                .Index(t => t.ImprovementId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "ImprovementId", "dbo.Improvements");
            DropIndex("dbo.Comments", new[] { "ImprovementId" });
            DropTable("dbo.Comments");
        }
    }
}

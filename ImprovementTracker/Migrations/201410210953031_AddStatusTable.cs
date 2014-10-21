namespace ImprovementTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true ),
                        StatusName = c.String(nullable: false, maxLength: 50),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO STATUS VALUES('TODO', 1)");
            Sql("INSERT INTO STATUS VALUES('INPROGRESS', 1)");
            Sql("INSERT INTO STATUS VALUES('COMPLETE', 1)");

            AddColumn("dbo.Improvements", "StatusId", c => c.Int(nullable: true));
            Sql("UPDATE Improvements SET STATUSID = STATUS +1");
            AlterColumn("dbo.Improvements", "StatusId", c => c.Int(nullable: false));
            CreateIndex("dbo.Improvements", "StatusId");
            AddForeignKey("dbo.Improvements", "StatusId", "dbo.Status", "Id", cascadeDelete: true);
            DropColumn("dbo.Improvements", "Status");

        }
        
        public override void Down()
        {
            AddColumn("dbo.Improvements", "Status", c => c.Int(nullable: false));
            DropForeignKey("dbo.Improvements", "StatusId", "dbo.Status");
            DropIndex("dbo.Improvements", new[] { "StatusId" });
            DropColumn("dbo.Improvements", "StatusId");
            DropTable("dbo.Status");
        }
    }
}

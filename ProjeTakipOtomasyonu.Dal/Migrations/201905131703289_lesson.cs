namespace ProjeTakipOtomasyonu.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class lesson : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Lessons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Students", "Lesson_Id", c => c.Int());
            AddColumn("dbo.WeeklyControls", "Lessson_Id", c => c.Int());
            CreateIndex("dbo.Students", "Lesson_Id");
            CreateIndex("dbo.WeeklyControls", "Lessson_Id");
            AddForeignKey("dbo.Students", "Lesson_Id", "dbo.Lessons", "Id");
            AddForeignKey("dbo.WeeklyControls", "Lessson_Id", "dbo.Lessons", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeeklyControls", "Lessson_Id", "dbo.Lessons");
            DropForeignKey("dbo.Students", "Lesson_Id", "dbo.Lessons");
            DropIndex("dbo.WeeklyControls", new[] { "Lessson_Id" });
            DropIndex("dbo.Students", new[] { "Lesson_Id" });
            DropColumn("dbo.WeeklyControls", "Lessson_Id");
            DropColumn("dbo.Students", "Lesson_Id");
            DropTable("dbo.Lessons");
        }
    }
}

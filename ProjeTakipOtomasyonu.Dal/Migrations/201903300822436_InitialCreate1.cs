namespace ProjeTakipOtomasyonu.Dal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WeeklyControls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        WeekName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WeeklyControlSubItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsControl = c.Boolean(nullable: false),
                        Student_Id = c.Int(),
                        WeeklyControl_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Students", t => t.Student_Id)
                .ForeignKey("dbo.WeeklyControls", t => t.WeeklyControl_Id)
                .Index(t => t.Student_Id)
                .Index(t => t.WeeklyControl_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WeeklyControlSubItems", "WeeklyControl_Id", "dbo.WeeklyControls");
            DropForeignKey("dbo.WeeklyControlSubItems", "Student_Id", "dbo.Students");
            DropIndex("dbo.WeeklyControlSubItems", new[] { "WeeklyControl_Id" });
            DropIndex("dbo.WeeklyControlSubItems", new[] { "Student_Id" });
            DropTable("dbo.WeeklyControlSubItems");
            DropTable("dbo.WeeklyControls");
        }
    }
}

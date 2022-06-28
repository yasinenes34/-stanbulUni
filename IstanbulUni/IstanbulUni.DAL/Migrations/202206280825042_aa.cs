namespace IstanbulUni.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aa : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        StudentNo = c.Int(nullable: false),
                        UniversityName = c.String(),
                        examScore = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            DropColumn("dbo.User", "Name");
            DropColumn("dbo.User", "Surname");
            DropColumn("dbo.User", "Phone");
            DropColumn("dbo.User", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.User", "Username", c => c.String());
            AddColumn("dbo.User", "Phone", c => c.String());
            AddColumn("dbo.User", "Surname", c => c.String());
            AddColumn("dbo.User", "Name", c => c.String());
            DropTable("dbo.Student");
        }
    }
}

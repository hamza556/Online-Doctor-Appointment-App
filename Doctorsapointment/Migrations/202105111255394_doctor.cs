namespace Doctorsapointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doctor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Adminid = c.Int(nullable: false, identity: true),
                        email = c.String(),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.Adminid);
            
            CreateTable(
                "dbo.doctors",
                c => new
                    {
                        Regid = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        mail = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        address = c.String(nullable: false),
                        designation = c.String(nullable: false),
                        speciality = c.String(nullable: false),
                        pmdc = c.String(nullable: false),
                        image = c.String(),
                        password = c.String(nullable: false),
                        Cpassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Regid);
            
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Userid = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        mail = c.String(nullable: false),
                        phone = c.String(nullable: false),
                        gndr = c.Int(nullable: false),
                        address = c.String(nullable: false),
                        password = c.String(nullable: false),
                        Cpassword = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Userid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.users");
            DropTable("dbo.doctors");
            DropTable("dbo.Admins");
        }
    }
}

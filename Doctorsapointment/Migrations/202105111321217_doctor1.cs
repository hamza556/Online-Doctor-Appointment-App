namespace Doctorsapointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doctor1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.doctors", "name", c => c.String());
            AlterColumn("dbo.doctors", "phone", c => c.String());
            AlterColumn("dbo.doctors", "address", c => c.String());
            AlterColumn("dbo.doctors", "designation", c => c.String());
            AlterColumn("dbo.doctors", "speciality", c => c.String());
            AlterColumn("dbo.doctors", "pmdc", c => c.String());
            AlterColumn("dbo.doctors", "password", c => c.String());
            AlterColumn("dbo.doctors", "Cpassword", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.doctors", "Cpassword", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "password", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "pmdc", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "speciality", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "designation", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "address", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "phone", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "name", c => c.String(nullable: false));
        }
    }
}

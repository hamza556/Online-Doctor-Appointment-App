namespace Doctorsapointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doctor3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.doctors", "pmdc", c => c.String(nullable: false));
            AlterColumn("dbo.doctors", "password", c => c.String(nullable: false));
            DropColumn("dbo.doctors", "image");
            DropColumn("dbo.doctors", "Cpassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.doctors", "Cpassword", c => c.String());
            AddColumn("dbo.doctors", "image", c => c.String());
            AlterColumn("dbo.doctors", "password", c => c.String());
            AlterColumn("dbo.doctors", "pmdc", c => c.String());
        }
    }
}

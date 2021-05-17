namespace Doctorsapointment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class doctor2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.users", "Cpassword");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "Cpassword", c => c.String(nullable: false));
        }
    }
}

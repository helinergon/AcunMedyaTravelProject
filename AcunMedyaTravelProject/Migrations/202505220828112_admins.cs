namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admins : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "LoginCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "LoginCount");
        }
    }
}

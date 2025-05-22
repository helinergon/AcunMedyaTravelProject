namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admin : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Admins", "Email");
        }
    }
}

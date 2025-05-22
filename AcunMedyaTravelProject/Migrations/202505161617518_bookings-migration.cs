namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookingsmigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bookings", "TravelDateStart", c => c.DateTime());
            AlterColumn("dbo.Bookings", "TravelDateEnd", c => c.DateTime());
            AlterColumn("dbo.Bookings", "IsFavorite", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Bookings", "IsFavorite", c => c.String());
            AlterColumn("dbo.Bookings", "TravelDateEnd", c => c.String());
            AlterColumn("dbo.Bookings", "TravelDateStart", c => c.String());
        }
    }
}

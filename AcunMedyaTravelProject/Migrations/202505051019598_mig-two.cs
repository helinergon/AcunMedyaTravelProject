namespace AcunMedyaTravelProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migtwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminID);
            
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingsID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TravelDateStart = c.String(),
                        TravelDateEnd = c.String(),
                        OrganizerName = c.String(),
                        Location = c.String(),
                        AttendeesCount = c.String(),
                        ImageUrl = c.String(),
                        IsFavorite = c.String(),
                    })
                .PrimaryKey(t => t.BookingsID);
            
            CreateTable(
                "dbo.BookingSteps",
                c => new
                    {
                        BookingStepsID = c.Int(nullable: false, identity: true),
                        StepOrder = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        IconeName = c.String(),
                    })
                .PrimaryKey(t => t.BookingStepsID);
            
            CreateTable(
                "dbo.Destinations",
                c => new
                    {
                        DestinationsID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        Title = c.String(),
                        DaysTrip = c.String(),
                        Price = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DestinationsID);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServicesID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServicesID);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        SliderID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SliderID);
            
            CreateTable(
                "dbo.Sponsors",
                c => new
                    {
                        SponsorID = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.SponsorID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sponsors");
            DropTable("dbo.Sliders");
            DropTable("dbo.Services");
            DropTable("dbo.Destinations");
            DropTable("dbo.BookingSteps");
            DropTable("dbo.Bookings");
            DropTable("dbo.Admins");
        }
    }
}

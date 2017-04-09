namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSeatsAndUniqueIndeces : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Shows", newName: "Screenings");
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropIndex("dbo.Cinemas", new[] { "TownId" });
            DropIndex("dbo.Tickets", new[] { "ShowId" });
            RenameColumn(table: "dbo.Tickets", name: "ShowId", newName: "ScreeningId");
            CreateTable(
                "dbo.Seats",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Row = c.Int(nullable: false),
                        Number = c.Int(nullable: false),
                        AuditoriumId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auditoriums", t => t.AuditoriumId)
                .Index(t => new { t.Number, t.AuditoriumId }, unique: true, name: "IX_SeatNumberAuditorium");
            
            AddColumn("dbo.Auditoriums", "SeatsCount", c => c.Int(nullable: false));
            AddColumn("dbo.Tickets", "SeatId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Cinemas", "TownId", c => c.Int());
            AlterColumn("dbo.Movies", "AgeRestriction", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "Type", c => c.Int(nullable: false));
            AlterColumn("dbo.Users", "Role", c => c.Int(nullable: false));
            CreateIndex("dbo.Cinemas", "TownId");
            CreateIndex("dbo.Tickets", new[] { "ScreeningId", "SeatId" }, unique: true, name: "IX_ScreeningSeat");
            AddForeignKey("dbo.Tickets", "SeatId", "dbo.Seats", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Cinemas", "TownId", "dbo.Towns", "Id");
            DropColumn("dbo.Auditoriums", "Schema");
            DropColumn("dbo.Screenings", "End");
            DropColumn("dbo.Tickets", "Row");
            DropColumn("dbo.Tickets", "Col");
            DropColumn("dbo.Users", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "Phone", c => c.String());
            AddColumn("dbo.Tickets", "Col", c => c.Byte(nullable: false));
            AddColumn("dbo.Tickets", "Row", c => c.Byte(nullable: false));
            AddColumn("dbo.Screenings", "End", c => c.DateTime(nullable: false));
            AddColumn("dbo.Auditoriums", "Schema", c => c.String(nullable: false));
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropForeignKey("dbo.Tickets", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Seats", "AuditoriumId", "dbo.Auditoriums");
            DropIndex("dbo.Seats", "IX_SeatNumberAuditorium");
            DropIndex("dbo.Tickets", "IX_ScreeningSeat");
            DropIndex("dbo.Cinemas", new[] { "TownId" });
            AlterColumn("dbo.Users", "Role", c => c.String());
            AlterColumn("dbo.Tickets", "Type", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "AgeRestriction", c => c.String(nullable: false));
            AlterColumn("dbo.Cinemas", "TownId", c => c.Int(nullable: false));
            DropColumn("dbo.Users", "PhoneNumber");
            DropColumn("dbo.Tickets", "SeatId");
            DropColumn("dbo.Auditoriums", "SeatsCount");
            DropTable("dbo.Seats");
            RenameColumn(table: "dbo.Tickets", name: "ScreeningId", newName: "ShowId");
            CreateIndex("dbo.Tickets", "ShowId");
            CreateIndex("dbo.Cinemas", "TownId");
            AddForeignKey("dbo.Cinemas", "TownId", "dbo.Towns", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Screenings", newName: "Shows");
        }
    }
}

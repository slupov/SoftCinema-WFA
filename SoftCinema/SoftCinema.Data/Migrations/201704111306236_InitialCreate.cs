namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actors",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Rating = c.Single(),
                    BornTownId = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towns", t => t.BornTownId)
                .Index(t => t.BornTownId);

            CreateTable(
                "dbo.Towns",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Cinemas",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                    TownId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Towns", t => t.TownId, cascadeDelete: true)
                .Index(t => new { t.Name, t.TownId }, unique: true, name: "IX_CinemaTown");

            CreateTable(
                "dbo.Auditoriums",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Number = c.Byte(nullable: false),
                    CinemaId = c.Int(nullable: false),
                    SeatsCount = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cinemas", t => t.CinemaId, cascadeDelete: true)
                .Index(t => new { t.Number, t.CinemaId }, unique: true, name: "IX_CinemaNumber");

            CreateTable(
                "dbo.Screenings",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Start = c.DateTime(nullable: false),
                    AuditoriumId = c.Int(nullable: false),
                    MovieId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Auditoriums", t => t.AuditoriumId, cascadeDelete: true)
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.AuditoriumId)
                .Index(t => t.MovieId);

            CreateTable(
                "dbo.Movies",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Length = c.Int(nullable: false),
                    Rating = c.Single(),
                    Synopsis = c.String(),
                    DirectorName = c.String(nullable: false),
                    ReleaseYear = c.Int(nullable: false),
                    ReleaseCountry = c.String(),
                    AgeRestriction = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false, maxLength: 50),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true);

            CreateTable(
                "dbo.Tickets",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    HolderId = c.Int(nullable: false),
                    ScreeningId = c.Int(nullable: false),
                    SeatId = c.Int(nullable: false),
                    Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Type = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.HolderId, cascadeDelete: true)
                .ForeignKey("dbo.Screenings", t => t.ScreeningId, cascadeDelete: true)
                .ForeignKey("dbo.Seats", t => t.SeatId, cascadeDelete: true)
                .Index(t => t.HolderId)
                .Index(t => new { t.ScreeningId, t.SeatId }, unique: true, name: "IX_ScreeningSeat");

            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Username = c.String(nullable: false, maxLength: 25),
                    PasswordHash = c.Binary(nullable: false),
                    PhoneNumber = c.String(),
                    Email = c.String(nullable: false, maxLength: 30),
                    Role = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Username, unique: true)
                .Index(t => t.Email, unique: true);

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

            CreateTable(
                "dbo.ActorMovies",
                c => new
                {
                    ActorId = c.Int(nullable: false),
                    MovieId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.ActorId, t.MovieId })
                .ForeignKey("dbo.Movies", t => t.ActorId, cascadeDelete: true)
                .ForeignKey("dbo.Actors", t => t.MovieId, cascadeDelete: true)
                .Index(t => t.ActorId)
                .Index(t => t.MovieId);

            CreateTable(
                "dbo.MoviesCategories",
                c => new
                {
                    MovieId = c.Int(nullable: false),
                    CategoryId = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.MovieId, t.CategoryId })
                .ForeignKey("dbo.Movies", t => t.MovieId, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.MovieId)
                .Index(t => t.CategoryId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropForeignKey("dbo.Tickets", "SeatId", "dbo.Seats");
            DropForeignKey("dbo.Seats", "AuditoriumId", "dbo.Auditoriums");
            DropForeignKey("dbo.Tickets", "ScreeningId", "dbo.Screenings");
            DropForeignKey("dbo.Tickets", "HolderId", "dbo.Users");
            DropForeignKey("dbo.Screenings", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.MoviesCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.MoviesCategories", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.ActorMovies", "MovieId", "dbo.Actors");
            DropForeignKey("dbo.ActorMovies", "ActorId", "dbo.Movies");
            DropForeignKey("dbo.Screenings", "AuditoriumId", "dbo.Auditoriums");
            DropForeignKey("dbo.Auditoriums", "CinemaId", "dbo.Cinemas");
            DropForeignKey("dbo.Actors", "BornTownId", "dbo.Towns");
            DropIndex("dbo.MoviesCategories", new[] { "CategoryId" });
            DropIndex("dbo.MoviesCategories", new[] { "MovieId" });
            DropIndex("dbo.ActorMovies", new[] { "MovieId" });
            DropIndex("dbo.ActorMovies", new[] { "ActorId" });
            DropIndex("dbo.Seats", "IX_SeatNumberAuditorium");
            DropIndex("dbo.Users", new[] { "Email" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Tickets", "IX_ScreeningSeat");
            DropIndex("dbo.Tickets", new[] { "HolderId" });
            DropIndex("dbo.Categories", new[] { "Name" });
            DropIndex("dbo.Screenings", new[] { "MovieId" });
            DropIndex("dbo.Screenings", new[] { "AuditoriumId" });
            DropIndex("dbo.Auditoriums", "IX_CinemaNumber");
            DropIndex("dbo.Cinemas", "IX_CinemaTown");
            DropIndex("dbo.Actors", new[] { "BornTownId" });
            DropTable("dbo.MoviesCategories");
            DropTable("dbo.ActorMovies");
            DropTable("dbo.Seats");
            DropTable("dbo.Users");
            DropTable("dbo.Tickets");
            DropTable("dbo.Categories");
            DropTable("dbo.Movies");
            DropTable("dbo.Screenings");
            DropTable("dbo.Auditoriums");
            DropTable("dbo.Cinemas");
            DropTable("dbo.Towns");
            DropTable("dbo.Actors");
        }
    }
}
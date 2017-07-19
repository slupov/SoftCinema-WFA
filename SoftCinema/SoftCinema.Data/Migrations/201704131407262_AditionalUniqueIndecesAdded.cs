namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AditionalUniqueIndecesAdded : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Screenings", new[] { "AuditoriumId" });
            DropIndex("dbo.Screenings", new[] { "MovieId" });
            AlterColumn("dbo.Actors", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Actors", "Name", unique: true);
            CreateIndex("dbo.Screenings", new[] { "MovieId", "AuditoriumId", "Start" }, unique: true, name: "IX_MovieAuditoriumDate");
            CreateIndex("dbo.Movies", new[] { "Name", "ReleaseYear" }, unique: true, name: "IX_NameYear");
        }

        public override void Down()
        {
            DropIndex("dbo.Movies", "IX_NameYear");
            DropIndex("dbo.Screenings", "IX_MovieAuditoriumDate");
            DropIndex("dbo.Actors", new[] { "Name" });
            AlterColumn("dbo.Movies", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Actors", "Name", c => c.String(nullable: false));
            CreateIndex("dbo.Screenings", "MovieId");
            CreateIndex("dbo.Screenings", "AuditoriumId");
        }
    }
}
namespace SoftCinema.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.MovieActors", newName: "ActorMovies");
            RenameColumn(table: "dbo.ActorMovies", name: "Movie_Id", newName: "ActorId");
            RenameColumn(table: "dbo.ActorMovies", name: "Actor_Id", newName: "MovieId");
            RenameColumn(table: "dbo.Tickets", name: "UserId", newName: "HolderId");
            RenameIndex(table: "dbo.Tickets", name: "IX_UserId", newName: "IX_HolderId");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_Movie_Id", newName: "IX_ActorId");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_Actor_Id", newName: "IX_MovieId");
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
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
            
            AddColumn("dbo.Actors", "BornTownId", c => c.Int());
            AddColumn("dbo.Cinemas", "TownId", c => c.Int(nullable: false));
            AlterColumn("dbo.Actors", "Rating", c => c.Single());
            AlterColumn("dbo.Movies", "Rating", c => c.Single());
            CreateIndex("dbo.Actors", "BornTownId");
            CreateIndex("dbo.Cinemas", "TownId");
            AddForeignKey("dbo.Actors", "BornTownId", "dbo.Towns", "Id");
            AddForeignKey("dbo.Cinemas", "TownId", "dbo.Towns", "Id", cascadeDelete: true);
            DropColumn("dbo.Cinemas", "Town");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cinemas", "Town", c => c.String());
            DropForeignKey("dbo.Cinemas", "TownId", "dbo.Towns");
            DropForeignKey("dbo.MoviesCategories", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.MoviesCategories", "MovieId", "dbo.Movies");
            DropForeignKey("dbo.Actors", "BornTownId", "dbo.Towns");
            DropIndex("dbo.MoviesCategories", new[] { "CategoryId" });
            DropIndex("dbo.MoviesCategories", new[] { "MovieId" });
            DropIndex("dbo.Cinemas", new[] { "TownId" });
            DropIndex("dbo.Actors", new[] { "BornTownId" });
            AlterColumn("dbo.Movies", "Rating", c => c.Single(nullable: false));
            AlterColumn("dbo.Actors", "Rating", c => c.Single(nullable: false));
            DropColumn("dbo.Cinemas", "TownId");
            DropColumn("dbo.Actors", "BornTownId");
            DropTable("dbo.MoviesCategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Towns");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_MovieId", newName: "IX_Actor_Id");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_ActorId", newName: "IX_Movie_Id");
            RenameIndex(table: "dbo.Tickets", name: "IX_HolderId", newName: "IX_UserId");
            RenameColumn(table: "dbo.Tickets", name: "HolderId", newName: "UserId");
            RenameColumn(table: "dbo.ActorMovies", name: "MovieId", newName: "Actor_Id");
            RenameColumn(table: "dbo.ActorMovies", name: "ActorId", newName: "Movie_Id");
            RenameTable(name: "dbo.ActorMovies", newName: "MovieActors");
        }
    }
}

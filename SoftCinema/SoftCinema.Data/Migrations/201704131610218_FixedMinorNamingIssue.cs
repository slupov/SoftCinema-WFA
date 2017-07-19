namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class FixedMinorNamingIssue : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.ActorMovies", name: "ActorId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.ActorMovies", name: "MovieId", newName: "ActorId");
            RenameColumn(table: "dbo.ActorMovies", name: "__mig_tmp__0", newName: "MovieId");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_ActorId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_MovieId", newName: "IX_ActorId");
            RenameIndex(table: "dbo.ActorMovies", name: "__mig_tmp__0", newName: "IX_MovieId");
        }

        public override void Down()
        {
            RenameIndex(table: "dbo.ActorMovies", name: "IX_MovieId", newName: "__mig_tmp__0");
            RenameIndex(table: "dbo.ActorMovies", name: "IX_ActorId", newName: "IX_MovieId");
            RenameIndex(table: "dbo.ActorMovies", name: "__mig_tmp__0", newName: "IX_ActorId");
            RenameColumn(table: "dbo.ActorMovies", name: "MovieId", newName: "__mig_tmp__0");
            RenameColumn(table: "dbo.ActorMovies", name: "ActorId", newName: "MovieId");
            RenameColumn(table: "dbo.ActorMovies", name: "__mig_tmp__0", newName: "ActorId");
        }
    }
}
namespace SoftCinema.Data.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class AddedUniqueTownNameIndex : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Towns", "Name", unique: true);
        }

        public override void Down()
        {
            DropIndex("dbo.Towns", new[] { "Name" });
            AlterColumn("dbo.Towns", "Name", c => c.String(nullable: false));
        }
    }
}
using FluentMigrator;


namespace Parcial.Migrations
{
    [Migration(1)]
    public class PlayerTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("1_PlayerTable.sql");
        }

        public override void Down()
        {
        }
    }
}

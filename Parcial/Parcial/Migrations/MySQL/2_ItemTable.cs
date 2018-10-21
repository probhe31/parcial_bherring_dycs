using FluentMigrator;


namespace Parcial.Migrations
{
    [Migration(2)]
    public class ItemTable : Migration
    {
        public override void Up()
        {
            Execute.EmbeddedScript("2_ItemTable.sql");
        }

        public override void Down()
        {
        }
    }
}

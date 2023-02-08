using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_DexterStephens.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Title = table.Column<string>(nullable: false),
                    Category = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Title);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Dark Knight", "Action/Adventure", "Christopher Nolan", false, null, null, "PG-13", 2008 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Cars", "Action/Adventure", "John Lasseter", false, null, null, "G", 2006 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Title", "Category", "Director", "Edited", "LentTo", "Notes", "Rating", "Year" },
                values: new object[] { "Harry Potter and the Chamber of Secrets", "Action/Adventure", "Chris Columbus", false, null, null, "PG", 2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

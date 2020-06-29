using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dockertraining_compose_fernando_castellanos.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    US_Gross = table.Column<int>(nullable: true),
                    Worldwide_Gross = table.Column<long>(nullable: true),
                    US_DVD_Sales = table.Column<int>(nullable: true),
                    Production_Budget = table.Column<int>(nullable: true),
                    Release_Date = table.Column<string>(nullable: true),
                    MPAA_Rating = table.Column<string>(nullable: true),
                    Running_Time_min = table.Column<int>(nullable: true),
                    Distributor = table.Column<string>(nullable: true),
                    Source = table.Column<string>(nullable: true),
                    Major_Genre = table.Column<string>(nullable: true),
                    Creative_Type = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    Rotten_Tomatoes_Rating = table.Column<int>(nullable: true),
                    IMDB_Rating = table.Column<double>(nullable: true),
                    IMDB_Votes = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace RodentMedia.Migrations
{
    public partial class intial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MediaTypes",
                columns: table => new
                {
                    MediaTypeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MediaTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MediaTypes", x => x.MediaTypeId);
                });

            migrationBuilder.CreateTable(
                name: "RatMedia",
                columns: table => new
                {
                    MediaId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Image = table.Column<string>(nullable: false),
                    MediaName = table.Column<string>(nullable: false),
                    RatName = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    MediaTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RatMedia", x => x.MediaId);
                    table.ForeignKey(
                        name: "FK_RatMedia_MediaTypes_MediaTypeId",
                        column: x => x.MediaTypeId,
                        principalTable: "MediaTypes",
                        principalColumn: "MediaTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 1, "Movie" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 2, "Book" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 3, "Television" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 4, "Music" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 5, "Image" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 6, "Theater" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 7, "Printed Publication" });

            migrationBuilder.InsertData(
                table: "MediaTypes",
                columns: new[] { "MediaTypeId", "MediaTypeName" },
                values: new object[] { 8, "Other" });

            migrationBuilder.InsertData(
                table: "RatMedia",
                columns: new[] { "MediaId", "Description", "Image", "MediaName", "MediaTypeId", "RatName", "Year" },
                values: new object[] { 2, "The main protagonist who befriends a worker at a famous Parisian restaurant and assists him in his culinary career.", "https://resizing.flixster.com/gL_JpWcD7sNHNYSwI1ff069Yyug=/ems.ZW1zLXByZC1hc3NldHMvbW92aWVzLzc4ZmJhZjZiLTEzNWMtNDIwOC1hYzU1LTgwZjE3ZjQzNTdiNy5qcGc=", "Ratatouille", 1, "Remy", 2007 });

            migrationBuilder.InsertData(
                table: "RatMedia",
                columns: new[] { "MediaId", "Description", "Image", "MediaName", "MediaTypeId", "RatName", "Year" },
                values: new object[] { 1, "Templeton is a rat who helps Charlotte and Wilbur only when offered food. He serves as a somewhat caustic, self-serving comic relief to the plot.", "https://images-na.ssl-images-amazon.com/images/I/916JW20V3yL.jpg", "Charlotte's Web", 2, "Templeton", 1952 });

            migrationBuilder.InsertData(
                table: "RatMedia",
                columns: new[] { "MediaId", "Description", "Image", "MediaName", "MediaTypeId", "RatName", "Year" },
                values: new object[] { 3, "During the night, the Rat King and his army fight against the Nutcracker and his fellow toy soldiers.", "https://images-na.ssl-images-amazon.com/images/I/81TxVwDLFnL.jpg", "The Nutcracker", 6, "The Rat King", 1892 });

            migrationBuilder.CreateIndex(
                name: "IX_RatMedia_MediaTypeId",
                table: "RatMedia",
                column: "MediaTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RatMedia");

            migrationBuilder.DropTable(
                name: "MediaTypes");
        }
    }
}

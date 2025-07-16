using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Mission.Entities.Migrations
{
    /// <inheritdoc />
    public partial class CreateNewMissionEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Missions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryId = table.Column<int>(type: "integer", nullable: false),
                    CityId = table.Column<int>(type: "integer", nullable: false),
                    MissionTitle = table.Column<string>(type: "text", nullable: false),
                    MissionThemeId = table.Column<int>(type: "integer", nullable: false),
                    MissionDescription = table.Column<string>(type: "text", nullable: false),
                    TotalSeats = table.Column<int>(type: "integer", nullable: false),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MissionImages = table.Column<string>(type: "text", nullable: false),
                    MissionSkillId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Missions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Missions_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Missions_MissionTheme_MissionThemeId",
                        column: x => x.MissionThemeId,
                        principalTable: "MissionTheme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            //migrationBuilder.InsertData(
            //    table: "Cities",
            //    columns: new[] { "Id", "CityName", "CountryId" },
            //    values: new object[,]
            //    {
            //        { 1, "Ahmedabad", 1 },
            //        { 2, "Rajkot", 1 },
            //        { 3, "Surat", 1 },
            //        { 4, "Jamnagar", 1 },
            //        { 5, "New York", 2 },
            //        { 6, "California", 2 },
            //        { 7, "Texas", 2 },
            //        { 8, "London", 3 },
            //        { 9, "Manchester", 3 },
            //        { 10, "Birmingham", 3 },
            //        { 11, "Moscow", 4 },
            //        { 12, "Saint Petersburg", 4 },
            //        { 13, "Yekaterinburg", 4 }
            //    });

            //migrationBuilder.InsertData(
            //    table: "Countries",
            //    columns: new[] { "Id", "CountryName" },
            //    values: new object[,]
            //    {
            //        { 1, "India" },
            //        { 2, "USA" },
            //        { 3, "UK" },
            //        { 4, "Russia" }
            //    });

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CityId",
                table: "Missions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_CountryId",
                table: "Missions",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Missions_MissionThemeId",
                table: "Missions",
                column: "MissionThemeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Missions");

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 4);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 5);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 6);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 7);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 8);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 9);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 10);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 11);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 12);

            //migrationBuilder.DeleteData(
            //    table: "Cities",
            //    keyColumn: "Id",
            //    keyValue: 13);

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: 1);

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: 2);

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: 3);

            //migrationBuilder.DeleteData(
            //    table: "Countries",
            //    keyColumn: "Id",
            //    keyValue: 4);
        }
    }
}

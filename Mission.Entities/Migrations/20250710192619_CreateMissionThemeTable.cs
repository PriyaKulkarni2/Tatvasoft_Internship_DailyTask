using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Mission.Entities.Migrations
{
    /// <inheritdoc />
    public partial class CreateMissionThemeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MissionSkill",
                table: "MissionSkill");

            migrationBuilder.RenameTable(
                name: "MissionSkill",
                newName: "MissionSkills");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MissionSkills",
                table: "MissionSkills",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "MissionTheme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThemeName = table.Column<string>(type: "text", nullable: false),
                    Status = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MissionTheme", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MissionTheme");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MissionSkills",
                table: "MissionSkills");

            migrationBuilder.RenameTable(
                name: "MissionSkills",
                newName: "MissionSkill");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MissionSkill",
                table: "MissionSkill",
                column: "Id");
        }
    }
}

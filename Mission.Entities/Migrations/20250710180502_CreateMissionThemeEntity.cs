using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mission.Entities.Migrations
{
    /// <inheritdoc />
    public partial class CreateMissionThemeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}

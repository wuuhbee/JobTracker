using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JobTracker.Migrations
{
    /// <inheritdoc />
    public partial class StatusUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Jobs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_StatusId",
                table: "Jobs",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Statuses_StatusId",
                table: "Jobs",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Statuses_StatusId",
                table: "Jobs");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_StatusId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "JobTitle",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

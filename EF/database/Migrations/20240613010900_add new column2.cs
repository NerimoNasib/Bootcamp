using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace database.Migrations
{
    /// <inheritdoc />
    public partial class addnewcolumn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SchoolID1",
                table: "Students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_SchoolID1",
                table: "Students",
                column: "SchoolID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolID1",
                table: "Students",
                column: "SchoolID1",
                principalTable: "Schools",
                principalColumn: "SchoolID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolID1",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_SchoolID1",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "SchoolID1",
                table: "Students");
        }
    }
}

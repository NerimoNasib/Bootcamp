using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace database.Migrations
{
    /// <inheritdoc />
    public partial class changedkeyagain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Students_StudentID1",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_StudentID1",
                table: "Schools");

            migrationBuilder.DropColumn(
                name: "StudentID1",
                table: "Schools");

            migrationBuilder.AlterColumn<int>(
                name: "SchoolID",
                table: "Schools",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Schools",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                table: "Schools",
                column: "SchoolID");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_StudentID",
                table: "Schools",
                column: "StudentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Students_StudentID",
                table: "Schools",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Schools_Students_StudentID",
                table: "Schools");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schools",
                table: "Schools");

            migrationBuilder.DropIndex(
                name: "IX_Schools_StudentID",
                table: "Schools");

            migrationBuilder.AlterColumn<int>(
                name: "StudentID",
                table: "Schools",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AlterColumn<int>(
                name: "SchoolID",
                table: "Schools",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "StudentID1",
                table: "Schools",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schools",
                table: "Schools",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Schools_StudentID1",
                table: "Schools",
                column: "StudentID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Schools_Students_StudentID1",
                table: "Schools",
                column: "StudentID1",
                principalTable: "Students",
                principalColumn: "StudentID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

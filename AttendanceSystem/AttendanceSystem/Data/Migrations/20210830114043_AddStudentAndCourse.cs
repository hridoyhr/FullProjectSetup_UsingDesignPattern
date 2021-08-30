using Microsoft.EntityFrameworkCore.Migrations;

namespace AttendanceSystem.Data.Migrations
{
    public partial class AddStudentAndCourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_students",
                table: "students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_attendances",
                table: "attendances");

            migrationBuilder.RenameTable(
                name: "students",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "attendances",
                newName: "Attendances");

            migrationBuilder.RenameColumn(
                name: "StudentRollNumber",
                table: "Students",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "Attendances",
                newName: "Fees");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Attendances",
                newName: "StartDate");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Attendances",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseId",
                table: "Students",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Attendances_CourseId",
                table: "Students",
                column: "CourseId",
                principalTable: "Attendances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Attendances_CourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attendances",
                table: "Attendances");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Attendances");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "students");

            migrationBuilder.RenameTable(
                name: "Attendances",
                newName: "attendances");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "students",
                newName: "StudentRollNumber");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "attendances",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "Fees",
                table: "attendances",
                newName: "StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_students",
                table: "students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_attendances",
                table: "attendances",
                column: "Id");
        }
    }
}

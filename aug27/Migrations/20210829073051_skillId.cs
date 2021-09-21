using Microsoft.EntityFrameworkCore.Migrations;

namespace aug27.Migrations
{
    public partial class skillId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Departments_DepartmentId",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_DepartmentId",
                table: "EmployeeDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "EmployeeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_SkillId",
                table: "EmployeeDetails",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Departments_SkillId",
                table: "EmployeeDetails",
                column: "SkillId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeDetails_Departments_SkillId",
                table: "EmployeeDetails");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeDetails_SkillId",
                table: "EmployeeDetails");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "EmployeeDetails");

            migrationBuilder.AlterColumn<string>(
                name: "SkillName",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeDetails_DepartmentId",
                table: "EmployeeDetails",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeDetails_Departments_DepartmentId",
                table: "EmployeeDetails",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

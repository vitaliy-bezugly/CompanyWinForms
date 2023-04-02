using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repositories.Migrations
{
    /// <inheritdoc />
    public partial class fixednames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_DepartmentEntityid",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_DepartmentEntityid",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "DepartmentEntityid",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "departmentId",
                table: "Employee",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_departmentId",
                table: "Employee",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_departmentId",
                table: "Employee",
                column: "departmentId",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Department_departmentId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_departmentId",
                table: "Employee");

            migrationBuilder.AlterColumn<string>(
                name: "departmentId",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "DepartmentEntityid",
                table: "Employee",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentEntityid",
                table: "Employee",
                column: "DepartmentEntityid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Department_DepartmentEntityid",
                table: "Employee",
                column: "DepartmentEntityid",
                principalTable: "Department",
                principalColumn: "id");
        }
    }
}

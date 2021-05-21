using Microsoft.EntityFrameworkCore.Migrations;

namespace Task4.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "profiles",
                columns: new[] { "Id", "Age", "CurrentCTC", "ISEmployed", "Name", "NoticePeriod", "Qualification" },
                values: new object[] { 1, 20, 300000.0, true, "dhesh", 60, "B.E CSE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "profiles",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}

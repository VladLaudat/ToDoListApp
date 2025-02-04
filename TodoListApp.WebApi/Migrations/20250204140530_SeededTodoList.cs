using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class SeededTodoList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "todo_list",
                columns: new[] { "id", "description", "title" },
                values: new object[] { 1, "Description1", "Title1" });

            migrationBuilder.InsertData(
                table: "todo_list",
                columns: new[] { "id", "description", "title" },
                values: new object[] { 2, "Description2", "Title2" });

            migrationBuilder.InsertData(
                table: "todo_list",
                columns: new[] { "id", "description", "title" },
                values: new object[] { 3, "Description3", "Title3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 3);
        }
    }
}

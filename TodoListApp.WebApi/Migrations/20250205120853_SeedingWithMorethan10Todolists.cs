using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class SeedingWithMorethan10Todolists : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 1,
                column: "title",
                value: "TodoList1");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 2,
                column: "title",
                value: "TodoList2");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 3,
                column: "title",
                value: "TodoList3");

            migrationBuilder.InsertData(
                table: "todo_list",
                columns: new[] { "id", "description", "title" },
                values: new object[,]
                {
                    { 4, "Description4", "TodoList4" },
                    { 5, "Description5", "TodoList5" },
                    { 6, "Description6", "TodoList6" },
                    { 7, "Description7", "TodoList7" },
                    { 8, "Description8", "TodoList8" },
                    { 9, "Description9", "TodoList9" },
                    { 10, "Description10", "TodoList10" },
                    { 11, "Description11", "TodoList11" },
                    { 12, "Description12", "TodoList12" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 1,
                column: "title",
                value: "Title1");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 2,
                column: "title",
                value: "Title2");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 3,
                column: "title",
                value: "Title3");
        }
    }
}

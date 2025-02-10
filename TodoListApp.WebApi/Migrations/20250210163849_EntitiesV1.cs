using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class EntitiesV1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment");

            migrationBuilder.AlterColumn<int>(
                name: "task_id",
                table: "comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "comment",
                columns: new[] { "id", "comment", "task_id" },
                values: new object[,]
                {
                    { 1, "Comment1", null },
                    { 2, "Comment2", null },
                    { 3, "Comment3", null }
                });

            migrationBuilder.InsertData(
                table: "tag",
                columns: new[] { "id", "description" },
                values: new object[,]
                {
                    { 1, "TagDescription1" },
                    { 2, "TagDescription2" }
                });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9373), "TaskDescription1", new DateTime(2025, 2, 9, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9408), "TaskDescription2", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9412), "TaskDescription3", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9416), "TaskDescription4", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9420), "TaskDescription5", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9424), "TaskDescription6", new DateTime(2025, 2, 9, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9428), "TaskDescription7", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9431), "TaskDescription8", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9435), "TaskDescription9", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9439), "TaskDescription10", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9443), "TaskDescription11", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9447), "TaskDescription12", new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9448) });

            migrationBuilder.InsertData(
                table: "task_status",
                columns: new[] { "id", "description", "is_active" },
                values: new object[,]
                {
                    { 1, "Not Started", true },
                    { 2, "In Progess", true },
                    { 3, "Completed", false }
                });

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "TodoListDescription1");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "TodoListDescription2");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "TodoListDescription3");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "TodoListDescription4");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "TodoListDescription5");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "TodoListDescription6");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "TodoListDescription7");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 8,
                column: "description",
                value: "TodoListDescription8");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "TodoListDescription9");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 10,
                column: "description",
                value: "TodoListDescription10");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 11,
                column: "description",
                value: "TodoListDescription11");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 12,
                column: "description",
                value: "TodoListDescription12");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment",
                column: "task_id",
                principalTable: "task",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment");

            migrationBuilder.DeleteData(
                table: "comment",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "comment",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "comment",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "tag",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "tag",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "task_status",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "task_status",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "task_status",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.AlterColumn<int>(
                name: "task_id",
                table: "comment",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description1", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description2", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description3", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description4", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description5", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description6", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description7", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description8", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description9", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description10", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description11", null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "description", "due_date" },
                values: new object[] { null, "Description12", null });

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 1,
                column: "description",
                value: "Description1");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 2,
                column: "description",
                value: "Description2");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 3,
                column: "description",
                value: "Description3");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 4,
                column: "description",
                value: "Description4");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 5,
                column: "description",
                value: "Description5");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 6,
                column: "description",
                value: "Description6");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 7,
                column: "description",
                value: "Description7");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 8,
                column: "description",
                value: "Description8");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 9,
                column: "description",
                value: "Description9");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 10,
                column: "description",
                value: "Description10");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 11,
                column: "description",
                value: "Description11");

            migrationBuilder.UpdateData(
                table: "todo_list",
                keyColumn: "id",
                keyValue: 12,
                column: "description",
                value: "Description12");

            migrationBuilder.AddForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment",
                column: "task_id",
                principalTable: "task",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

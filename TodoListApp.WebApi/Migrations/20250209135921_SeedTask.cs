using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class SeedTask : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task");

            migrationBuilder.DropForeignKey(
                name: "FK_task_todo_list_todolist_id",
                table: "task");

            migrationBuilder.AlterColumn<int>(
                name: "todolist_id",
                table: "task",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "task_status_id",
                table: "task",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "due_date",
                table: "task",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "task",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.InsertData(
                table: "task",
                columns: new[] { "id", "created_date", "description", "due_date", "task_status_id", "title", "todolist_id" },
                values: new object[,]
                {
                    { 1, null, "Description1", null, null, "Task1", null },
                    { 2, null, "Description2", null, null, "Task2", null },
                    { 3, null, "Description3", null, null, "Task3", null },
                    { 4, null, "Description4", null, null, "Task4", null },
                    { 5, null, "Description5", null, null, "Task5", null },
                    { 6, null, "Description6", null, null, "Task6", null },
                    { 7, null, "Description7", null, null, "Task7", null },
                    { 8, null, "Description8", null, null, "Task8", null },
                    { 9, null, "Description9", null, null, "Task9", null },
                    { 10, null, "Description10", null, null, "Task10", null },
                    { 11, null, "Description11", null, null, "Task11", null },
                    { 12, null, "Description12", null, null, "Task12", null }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task",
                column: "task_status_id",
                principalTable: "task_status",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_task_todo_list_todolist_id",
                table: "task",
                column: "todolist_id",
                principalTable: "todo_list",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task");

            migrationBuilder.DropForeignKey(
                name: "FK_task_todo_list_todolist_id",
                table: "task");

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "task",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.AlterColumn<int>(
                name: "todolist_id",
                table: "task",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "task_status_id",
                table: "task",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "due_date",
                table: "task",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "created_date",
                table: "task",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task",
                column: "task_status_id",
                principalTable: "task_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_task_todo_list_todolist_id",
                table: "task",
                column: "todolist_id",
                principalTable: "todo_list",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

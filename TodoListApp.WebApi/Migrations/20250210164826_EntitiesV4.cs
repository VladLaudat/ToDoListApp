using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class EntitiesV4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task");

            migrationBuilder.AlterColumn<int>(
                name: "task_status_id",
                table: "task",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                table: "comment",
                keyColumn: "id",
                keyValue: 1,
                column: "task_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "comment",
                keyColumn: "id",
                keyValue: 2,
                column: "task_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "comment",
                keyColumn: "id",
                keyValue: 3,
                column: "task_id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1923), new DateTime(2025, 2, 9, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1952), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1955), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1959), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1963), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1966), new DateTime(2025, 2, 9, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1970), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1971) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1973), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1977), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1981), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1986) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1988), new DateTime(2025, 2, 24, 18, 48, 25, 774, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.AddForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment",
                column: "task_id",
                principalTable: "task",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task",
                column: "task_status_id",
                principalTable: "task_status",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment");

            migrationBuilder.DropForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task");

            migrationBuilder.AlterColumn<int>(
                name: "task_status_id",
                table: "task",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "task_id",
                table: "comment",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "comment",
                keyColumn: "id",
                keyValue: 1,
                column: "task_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "comment",
                keyColumn: "id",
                keyValue: 2,
                column: "task_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "comment",
                keyColumn: "id",
                keyValue: 3,
                column: "task_id",
                value: null);

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6532), new DateTime(2025, 2, 9, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6564) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6566), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6568) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6570), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6572) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6574), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6575) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6578), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6581), new DateTime(2025, 2, 9, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6583) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6585), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6587) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6589), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6590) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6593), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6594) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6597), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6598) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6600), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6602) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6604), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6605) });

            migrationBuilder.AddForeignKey(
                name: "FK_comment_task_task_id",
                table: "comment",
                column: "task_id",
                principalTable: "task",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_task_task_status_task_status_id",
                table: "task",
                column: "task_status_id",
                principalTable: "task_status",
                principalColumn: "id");
        }
    }
}

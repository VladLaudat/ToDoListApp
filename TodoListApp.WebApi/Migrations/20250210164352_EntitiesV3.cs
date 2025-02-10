using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class EntitiesV3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6532), new DateTime(2025, 2, 9, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6564), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6566), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6568), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6570), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6572), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6574), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6575), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6578), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6579), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6581), new DateTime(2025, 2, 9, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6583), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6585), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6587), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6589), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6590), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6593), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6594), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6597), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6598), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6600), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6602), 1 });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6604), new DateTime(2025, 2, 24, 18, 43, 51, 988, DateTimeKind.Local).AddTicks(6605), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9825), new DateTime(2025, 2, 9, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9855), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9857), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9859), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9863), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9866), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9868), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9870), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 2, 9, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9873), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9877), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9881), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9883), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9884), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9888), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9890), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9891), null });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date", "task_status_id" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9893), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9895), null });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class EntitiesV2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9825), new DateTime(2025, 2, 9, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9855) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9857), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9861), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9865), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9868), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9870) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9872), new DateTime(2025, 2, 9, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9876), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9877) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9879), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9881) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9883), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9886), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9890), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9891) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9893), new DateTime(2025, 2, 24, 18, 40, 37, 106, DateTimeKind.Local).AddTicks(9895) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9373), new DateTime(2025, 2, 9, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9408), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9412), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9414) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9416), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9418) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9420), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9424), new DateTime(2025, 2, 9, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9425) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9428), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9429) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9431), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9433) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9435), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9439), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9441) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9443), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9447), new DateTime(2025, 2, 24, 18, 38, 48, 903, DateTimeKind.Local).AddTicks(9448) });
        }
    }
}

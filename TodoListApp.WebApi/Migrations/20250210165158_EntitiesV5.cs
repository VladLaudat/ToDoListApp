using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoListApp.WebApi.Migrations
{
    public partial class EntitiesV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4233), new DateTime(2025, 2, 9, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4262) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4265), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4269), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4273), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4276), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4280), new DateTime(2025, 2, 9, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4284), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4286) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4288), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4289) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4292), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4295), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4299), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "task",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "created_date", "due_date" },
                values: new object[] { new DateTime(2025, 2, 10, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 2, 24, 18, 51, 57, 872, DateTimeKind.Local).AddTicks(4304) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

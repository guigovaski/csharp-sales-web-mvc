using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Technology" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Finance" });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Marketing" });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[] { 1, 8000.0, new DateTime(2000, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "gui@gmail.com", "Guizinho" });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[] { 2, 4500.0, new DateTime(2003, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "ste@gmail.com", "Stezinha" });

            migrationBuilder.InsertData(
                table: "Seller",
                columns: new[] { "Id", "BaseSalary", "BirthDate", "DepartmentId", "Email", "Name" },
                values: new object[] { 3, 3000.0, new DateTime(1989, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sol@gmail.com", "Solzinha" });

            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[] { 1, 2500.0, new DateTime(2022, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 });

            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[] { 2, 1200.0, new DateTime(2022, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 0 });

            migrationBuilder.InsertData(
                table: "SalesRecord",
                columns: new[] { "Id", "Amount", "Date", "SellerId", "Status" },
                values: new object[] { 3, 1000.0, new DateTime(2022, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SalesRecord",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seller",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Department",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

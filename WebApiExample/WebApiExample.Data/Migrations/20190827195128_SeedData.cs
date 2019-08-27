using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiExample.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Email", "Mobile", "Name" },
                values: new object[] { 1m, "john.doe@test.com", 9234567891m, "John Doe" });

            migrationBuilder.InsertData(
                table: "Transactions",
                columns: new[] { "ID", "Amount", "Currency", "CustomerID", "Date", "Status" },
                values: new object[,]
                {
                    { 1L, 22.3m, "USD", 1m, new DateTime(2019, 8, 26, 21, 51, 27, 889, DateTimeKind.Local).AddTicks(3604), "Success" },
                    { 2L, 2500.3m, "THB", 1m, new DateTime(2019, 8, 25, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9404), "Success" },
                    { 3L, 27800.3m, "THB", 1m, new DateTime(2019, 8, 24, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9422), "Canceled" },
                    { 4L, 200.3m, "THB", 1m, new DateTime(2019, 8, 23, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9425), "Canceled" },
                    { 5L, 200.31m, "THB", 1m, new DateTime(2019, 8, 22, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9427), "Canceled" },
                    { 6L, 200.32m, "THB", 1m, new DateTime(2019, 8, 21, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9430), "Canceled" },
                    { 7L, 200.31m, "THB", 1m, new DateTime(2019, 8, 20, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9432), "Canceled" },
                    { 8L, 200.31m, "THB", 1m, new DateTime(2019, 8, 19, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9438), "Canceled" },
                    { 9L, 200.31m, "THB", 1m, new DateTime(2019, 8, 18, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9440), "Canceled" },
                    { 10L, 200.31m, "THB", 1m, new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9443), "Canceled" },
                    { 11L, 200.31m, "JPY", 1m, new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9445), "Failed" },
                    { 12L, 200.31m, "JPY", 1m, new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9448), "Failed" },
                    { 13L, 200.31m, "JPY", 1m, new DateTime(2019, 8, 17, 21, 51, 27, 891, DateTimeKind.Local).AddTicks(9450), "Failed" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Transactions",
                keyColumn: "ID",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: 1m);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Address_Book.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataWithDiverseContacts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "john.doe@gmail.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "mpho.mokwena@outlook.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "jane.smith@yahoo.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "thabo.nkosi@hotmail.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "michael.johnson@icloud.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "lindiwe.dlamini@live.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "sarah.williams@protonmail.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "david.brown@zoho.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "sipho.khumalo@aol.com");

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "Email", "FullName", "PhoneNumber", "Province", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { 11, "234 Sunset Boulevard", "East London", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "nomsa.mbeki@outlook.com", "Nomsa Mbeki", "+27-43-789-0123", "Eastern Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "5201" },
                    { 12, "567 Mountain View Drive", "Worcester", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "pieter.vandermerwe@yahoo.com", "Pieter van der Merwe", "+27-23-890-1234", "Western Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "6850" },
                    { 13, "890 Valley Road", "Pietermaritzburg", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "z.mthembu@hotmail.com", "Zanele Mthembu", "+27-33-901-2345", "KwaZulu-Natal", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "3201" },
                    { 14, "123 Industrial Street", "Klerksdorp", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "johan.pretorius@icloud.com", "Johan Pretorius", "+27-18-012-3456", "North West", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "2571" },
                    { 15, "456 Heritage Lane", "Rustenburg", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "tebogo.modise@live.com", "Tebogo Modise", "+27-14-123-4567", "North West", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "0300" },
                    { 16, "789 Coastal Drive", "George", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "michelle.roberts@protonmail.com", "Michelle Roberts", "+27-44-234-5678", "Western Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "6529" },
                    { 17, "321 Mining Avenue", "Secunda", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "bongani.sibiya@zoho.com", "Bongani Sibiya", "+27-17-345-6789", "Mpumalanga", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "2302" },
                    { 18, "654 Commerce Street", "Sandton", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "anita.patel@aol.com", "Anita Patel", "+27-11-456-7890", "Gauteng", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "2196" },
                    { 19, "987 Wine Route", "Stellenbosch", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "francois.dutoit@mail.com", "Francois du Toit", "+27-21-567-8901", "Western Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "7600" },
                    { 20, "147 Golden Gate Road", "Bethlehem", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "lerato.maboe@yandex.com", "Lerato Maboe", "+27-58-678-9012", "Free State", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "9700" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "john.doe@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "mpho.mokwena@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "jane.smith@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "thabo.nkosi@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "michael.johnson@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "lindiwe.dlamini@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "sarah.williams@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "david.brown@example.com");

            migrationBuilder.UpdateData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "sipho.khumalo@example.com");
        }
    }
}

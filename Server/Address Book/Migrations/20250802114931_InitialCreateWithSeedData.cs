using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Address_Book.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FullName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Address = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    City = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "Email", "FullName", "PhoneNumber", "Province", "UpdatedAt", "ZipCode" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "123 Main St", "Cape Town", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "john.doe@example.com", "John Doe", "+27-21-123-4567", "Western Cape", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "8001" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "456 Oak Avenue", "Johannesburg", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "jane.smith@example.com", "Jane Smith", "+27-11-234-5678", "Gauteng", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "2001" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "789 Pine Road", "Durban", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "michael.johnson@example.com", "Michael Johnson", "+27-31-345-6789", "KwaZulu-Natal", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "4001" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "321 Elm Street", "Bloemfontein", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "sarah.williams@example.com", "Sarah Williams", "+27-51-456-7890", "Free State", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "9301" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "654 Maple Lane", "Port Elizabeth", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "david.brown@example.com", "David Brown", "+27-41-567-8901", "Eastern Cape", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "6001" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_Email",
                table: "Contacts",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Address_Book.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateWithIntIds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
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
                    { 1, "123 Main St", "Cape Town", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "john.doe@example.com", "John Doe", "+27-21-123-4567", "Western Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "8001" },
                    { 2, "789 High Street", "Pretoria", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "mpho.mokwena@example.com", "Mpho Mokwena", "+27-12-234-5678", "Gauteng", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "0001" },
                    { 3, "456 Oak Avenue", "Johannesburg", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "jane.smith@example.com", "Jane Smith", "+27-11-234-5678", "Gauteng", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "2001" },
                    { 4, "321 Pine Street", "Pretoria", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "thabo.nkosi@example.com", "Thabo Nkosi", "+27-12-345-6789", "Gauteng", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "0002" },
                    { 5, "789 Pine Road", "Durban", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "michael.johnson@example.com", "Michael Johnson", "+27-31-345-6789", "KwaZulu-Natal", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "4001" },
                    { 6, "123 Willow Street", "Durban", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "lindiwe.dlamini@example.com", "Lindiwe Dlamini", "+27-31-456-7890", "KwaZulu-Natal", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "4001" },
                    { 7, "321 Elm Street", "Bloemfontein", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "sarah.williams@example.com", "Sarah Williams", "+27-51-456-7890", "Free State", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "9301" },
                    { 8, "654 Maple Lane", "Port Elizabeth", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "david.brown@example.com", "David Brown", "+27-41-567-8901", "Eastern Cape", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "6001" },
                    { 9, "987 Cedar Road", "Bloemfontein", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "sipho.khumalo@example.com", "Sipho Khumalo", "+27-51-567-8901", "Free State", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "9301" },
                    { 10, "456 Birch Street", "Lephalale", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "deltaslep@gmail.com", "Deltas Lephalala", "+27-15-678-9012", "Limpopo", new DateTime(2024, 8, 2, 17, 48, 0, 0, DateTimeKind.Utc), "0555" }
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

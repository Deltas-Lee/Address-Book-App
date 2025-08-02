using Address_Book.Models;
using Microsoft.EntityFrameworkCore;

namespace Address_Book.Data
{
    public class AddressBookDbContext : DbContext
    {
        public AddressBookDbContext(DbContextOptions<AddressBookDbContext> options) : base(options) { }
        
        public DbSet<Contact> Contacts { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.FullName).IsRequired().HasMaxLength(100);
                entity.Property(c => c.Email).IsRequired().HasMaxLength(100);
                entity.HasIndex(c => c.Email).IsUnique();
                entity.Property(c => c.PhoneNumber).HasMaxLength(15);
                entity.Property(c => c.Address).HasMaxLength(200);
                entity.Property(c => c.City).HasMaxLength(50);
                entity.Property(c => c.Province).HasMaxLength(50);
                entity.Property(c => c.ZipCode).HasMaxLength(10);

                // Seed dummy data with STATIC values
                var seedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                
                entity.HasData(
                    new Contact
                    {
                        Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                        FullName = "John Doe",
                        Email = "john.doe@example.com",
                        PhoneNumber = "+27-21-123-4567",
                        Address = "123 Main St",
                        City = "Cape Town",
                        Province = "Western Cape",
                        ZipCode = "8001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                        FullName = "Jane Smith",
                        Email = "jane.smith@example.com",
                        PhoneNumber = "+27-11-234-5678",
                        Address = "456 Oak Avenue",
                        City = "Johannesburg",
                        Province = "Gauteng",
                        ZipCode = "2001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                        FullName = "Michael Johnson",
                        Email = "michael.johnson@example.com",
                        PhoneNumber = "+27-31-345-6789",
                        Address = "789 Pine Road",
                        City = "Durban",
                        Province = "KwaZulu-Natal",
                        ZipCode = "4001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                        FullName = "Sarah Williams",
                        Email = "sarah.williams@example.com",
                        PhoneNumber = "+27-51-456-7890",
                        Address = "321 Elm Street",
                        City = "Bloemfontein",
                        Province = "Free State",
                        ZipCode = "9301",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                        FullName = "David Brown",
                        Email = "david.brown@example.com",
                        PhoneNumber = "+27-41-567-8901",
                        Address = "654 Maple Lane",
                        City = "Port Elizabeth",
                        Province = "Eastern Cape",
                        ZipCode = "6001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    }
                );
            });
        }
    }
}
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
                var seedDate = new DateTime(2024, 8, 2, 17, 48, 0, DateTimeKind.Utc);
                
                entity.HasData(
                    new Contact
                    {
                        Id = 1,
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
                        Id = 2,
                        FullName = "Mpho Mokwena",
                        Email = "mpho.mokwena@example.com",
                        PhoneNumber = "+27-12-234-5678",
                        Address = "789 High Street",
                        City = "Pretoria",
                        Province = "Gauteng",
                        ZipCode = "0001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = 3,
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
                        Id = 4,
                        FullName = "Thabo Nkosi",
                        Email = "thabo.nkosi@example.com",
                        PhoneNumber = "+27-12-345-6789",
                        Address = "321 Pine Street",
                        City = "Pretoria",
                        Province = "Gauteng",
                        ZipCode = "0002",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = 5,
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
                        Id = 6,
                        FullName = "Lindiwe Dlamini",
                        Email = "lindiwe.dlamini@example.com",
                        PhoneNumber = "+27-31-456-7890",
                        Address = "123 Willow Street",
                        City = "Durban",
                        Province = "KwaZulu-Natal",
                        ZipCode = "4001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = 7,
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
                        Id = 8,
                        FullName = "David Brown",
                        Email = "david.brown@example.com",
                        PhoneNumber = "+27-41-567-8901",
                        Address = "654 Maple Lane",
                        City = "Port Elizabeth",
                        Province = "Eastern Cape",
                        ZipCode = "6001",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = 9,
                        FullName = "Sipho Khumalo",
                        Email = "sipho.khumalo@example.com",
                        PhoneNumber = "+27-51-567-8901",
                        Address = "987 Cedar Road",
                        City = "Bloemfontein",
                        Province = "Free State",
                        ZipCode = "9301",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    },
                    new Contact
                    {
                        Id = 10,
                        FullName = "Deltas Lephalala",
                        Email = "deltaslep@gmail.com",
                        PhoneNumber = "+27-15-678-9012",
                        Address = "456 Birch Street",
                        City = "Lephalale",
                        Province = "Limpopo",
                        ZipCode = "0555",
                        CreatedAt = seedDate,
                        UpdatedAt = seedDate
                    }
                );
            });
        }
    }
}
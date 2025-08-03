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

                // Seed data from external source
                entity.HasData(SeedData.GetContacts());
            });
        }
    }
}
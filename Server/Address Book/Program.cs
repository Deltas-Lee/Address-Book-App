using Address_Book.Data;
using Address_Book.Repositories;
using Address_Book.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace Address_Book
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            // Add Entity Framework Core with SQLite
            builder.Services.AddDbContext<AddressBookDbContext>(options =>
                options.UseSqlite("Data Source=addressbook.db"));

            // Register the contact repository & service layers
            builder.Services.AddScoped<IContactRepository, ContactRepository>();
            builder.Services.AddScoped<IContactService, ContactService>();

            // Add API explorer and swagger
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Address Book API",
                    Version = "v1",
                    Description = "A simple API for managing contacts in an address book.",
                    Contact = new OpenApiContact
                    {
                        Name = "Deltas Lephalala",
                        Email = "deltaslep@gmail.com",
                    }
                });
            });

            var app = builder.Build();

            // Ensure the database is created and seeded with initial data
            using (var scope = app.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AddressBookDbContext>();
                try
                {
                    context.Database.EnsureCreated();
                    app.Logger.LogInformation("Database created successfully.");
                }
                catch (Exception ex)
                {
                    app.Logger.LogError(ex, "An error occurred while creating the database.");
                }
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Address Book API V1");
                    c.RoutePrefix = string.Empty;
                    c.DocumentTitle = "Address Book API Documentation";
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}

using Address_Book.Models;

namespace Address_Book.Data
{
    public static class SeedData
    {
        public static Contact[] GetContacts()
        {
            var seedDate = new DateTime(2025, 8, 2, 17, 48, 0, DateTimeKind.Utc);

            return
            [
                new Contact
                {
                    Id = 1,
                    FullName = "John Doe",
                    Email = "john.doe@gmail.com",
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
                    Email = "mpho.mokwena@outlook.com",
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
                    Email = "jane.smith@yahoo.com",
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
                    Email = "thabo.nkosi@hotmail.com",
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
                    Email = "michael.johnson@icloud.com",
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
                    Email = "lindiwe.dlamini@live.com",
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
                    Email = "sarah.williams@protonmail.com",
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
                    Email = "david.brown@zoho.com",
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
                    Email = "sipho.khumalo@aol.com",
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
                },
                new Contact
                {
                    Id = 11,
                    FullName = "Nomsa Mbeki",
                    Email = "nomsa.mbeki@outlook.com",
                    PhoneNumber = "+27-43-789-0123",
                    Address = "234 Sunset Boulevard",
                    City = "East London",
                    Province = "Eastern Cape",
                    ZipCode = "5201",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 12,
                    FullName = "Pieter van der Merwe",
                    Email = "pieter.vandermerwe@yahoo.com",
                    PhoneNumber = "+27-23-890-1234",
                    Address = "567 Mountain View Drive",
                    City = "Worcester",
                    Province = "Western Cape",
                    ZipCode = "6850",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 13,
                    FullName = "Zanele Mthembu",
                    Email = "z.mthembu@hotmail.com",
                    PhoneNumber = "+27-33-901-2345",
                    Address = "890 Valley Road",
                    City = "Pietermaritzburg",
                    Province = "KwaZulu-Natal",
                    ZipCode = "3201",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 14,
                    FullName = "Johan Pretorius",
                    Email = "johan.pretorius@icloud.com",
                    PhoneNumber = "+27-18-012-3456",
                    Address = "123 Industrial Street",
                    City = "Klerksdorp",
                    Province = "North West",
                    ZipCode = "2571",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 15,
                    FullName = "Tebogo Modise",
                    Email = "tebogo.modise@live.com",
                    PhoneNumber = "+27-14-123-4567",
                    Address = "456 Heritage Lane",
                    City = "Rustenburg",
                    Province = "North West",
                    ZipCode = "0300",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 16,
                    FullName = "Michelle Roberts",
                    Email = "michelle.roberts@protonmail.com",
                    PhoneNumber = "+27-44-234-5678",
                    Address = "789 Coastal Drive",
                    City = "George",
                    Province = "Western Cape",
                    ZipCode = "6529",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 17,
                    FullName = "Bongani Sibiya",
                    Email = "bongani.sibiya@zoho.com",
                    PhoneNumber = "+27-17-345-6789",
                    Address = "321 Mining Avenue",
                    City = "Secunda",
                    Province = "Mpumalanga",
                    ZipCode = "2302",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 18,
                    FullName = "Anita Patel",
                    Email = "anita.patel@aol.com",
                    PhoneNumber = "+27-11-456-7890",
                    Address = "654 Commerce Street",
                    City = "Sandton",
                    Province = "Gauteng",
                    ZipCode = "2196",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 19,
                    FullName = "Francois du Toit",
                    Email = "francois.dutoit@mail.com",
                    PhoneNumber = "+27-21-567-8901",
                    Address = "987 Wine Route",
                    City = "Stellenbosch",
                    Province = "Western Cape",
                    ZipCode = "7600",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                },
                new Contact
                {
                    Id = 20,
                    FullName = "Lerato Maboe",
                    Email = "lerato.maboe@yandex.com",
                    PhoneNumber = "+27-58-678-9012",
                    Address = "147 Golden Gate Road",
                    City = "Bethlehem",
                    Province = "Free State",
                    ZipCode = "9700",
                    CreatedAt = seedDate,
                    UpdatedAt = seedDate
                }
            ];
        }
    }
}
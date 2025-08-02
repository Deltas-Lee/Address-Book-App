using Address_Book.Data;
using Address_Book.DTOs;
using Address_Book.Models;
using Microsoft.EntityFrameworkCore;

namespace Address_Book.Services
{
    public class ContactService(AddressBookDbContext context, ILogger<ContactService> logger) : IContactService
    {
        private readonly AddressBookDbContext _context = context ?? throw new ArgumentNullException(nameof(context));
        private readonly ILogger<ContactService> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public async Task<IEnumerable<ContactDTO>> GetAllContactsAsync()
        {
            var contacts = await _context.Contacts
                .OrderBy(c => c.FullName)
                .ToListAsync();

            return contacts.Select(MapToDto);
        }

        public async Task<ContactDTO?> GetContactByIdAsync(int id)
        {
            var contact = await _context.Contacts
                .FirstOrDefaultAsync(c => c.Id == id);
            if (contact == null)
            {
                _logger.LogWarning("Contact with ID {ContactId} not found.", id);
                return null;
            }
            return MapToDto(contact);
        }

        private static ContactDTO MapToDto(Contact contact)
        {
            return new ContactDTO
                (
                contact.Id,
                contact.FullName,
                contact.Email,
                contact.PhoneNumber,
                contact.Address,
                contact.City,
                contact.Province,
                contact.ZipCode,
                contact.CreatedAt,
                contact.UpdatedAt
            );
        }
    }
}

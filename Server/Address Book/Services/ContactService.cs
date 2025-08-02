using Address_Book.DTOs;
using Address_Book.Models;
using Address_Book.Repositories;

namespace Address_Book.Services
{
    public class ContactService(IContactRepository contactRepository, ILogger<ContactService> logger) : IContactService
    {
        private readonly IContactRepository _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
        private readonly ILogger<ContactService> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        public async Task<IEnumerable<ContactDTO>> GetAllContactsAsync(CancellationToken cancellationToken)
        {
            var contacts = await _contactRepository.GetAllContactsAsync(cancellationToken);
            return contacts.Select(MapToDto);
        }

        public async Task<ContactDTO?> GetContactByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            var contact = await _contactRepository.GetContactByIdAsync(id, cancellationToken);
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

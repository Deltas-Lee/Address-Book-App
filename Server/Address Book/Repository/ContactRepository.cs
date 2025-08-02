using Address_Book.Data;
using Address_Book.Models;
using Microsoft.EntityFrameworkCore;

namespace Address_Book.Repositories
{
    public class ContactRepository(AddressBookDbContext context) : IContactRepository
    {
        private readonly AddressBookDbContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public async Task<IEnumerable<Contact>> GetAllContactsAsync(CancellationToken cancellationToken = default)
        {
            return await _context.Contacts
                .OrderBy(c => c.FullName)
                .ToListAsync(cancellationToken);
        }

        public async Task<Contact?> GetContactByIdAsync(Guid id, CancellationToken cancellationToken = default)
        {
            return await _context.Contacts
                .FirstOrDefaultAsync(c => c.Id == id, cancellationToken);
        }
    }
}

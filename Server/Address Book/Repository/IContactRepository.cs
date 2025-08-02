using Address_Book.Models;

namespace Address_Book.Repositories
{
    public interface IContactRepository
    {
        Task<IEnumerable<Contact>> GetAllContactsAsync(CancellationToken cancellationToken = default);
        Task<Contact?> GetContactByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}

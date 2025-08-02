using Address_Book.DTOs;

namespace Address_Book.Services
{
    public interface IContactService
    {
        /// <summary>
        /// Retrieves all contacts asynchronously.
        /// </summary>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>A collection of contact DTOs.</returns>
        Task<IEnumerable<ContactDTO>> GetAllContactsAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a contact by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the contact. Must not be Guid.Empty.</param>
        /// <param name="cancellationToken">A token to cancel the operation.</param>
        /// <returns>The contact DTO if found; otherwise, null.</returns>
        Task<ContactDTO?> GetContactByIdAsync(Guid id, CancellationToken cancellationToken = default);
    }
}

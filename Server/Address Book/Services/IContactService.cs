using Address_Book.DTOs;

namespace Address_Book.Services
{
    public interface IContactService
    {
        /// <summary>
        /// Retrieves all contacts asynchronously.
        /// </summary>
        /// <returns>A collection of contact DTOs.</returns>
        Task<IEnumerable<ContactDTO>> GetAllContactsAsync();

        /// <summary>
        /// Retrieves a contact by its unique identifier asynchronously.
        /// </summary>
        /// <param name="id">The unique identifier of the contact.</param>
        /// <returns>The contact DTO if found; otherwise, null.</returns>
        Task<ContactDTO?> GetContactByIdAsync(int id);
    }
}

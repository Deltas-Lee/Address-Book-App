using Address_Book.DTOs;
using Address_Book.Repositories;
using Address_Book.Services;
using Microsoft.AspNetCore.Mvc;

namespace Address_Book.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ContactsController(IContactService contactService, ILogger<ContactsController> logger) : ControllerBase
    {
        private readonly IContactService _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
        private readonly ILogger<ContactsController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        /// <summary>
        /// Gets all contacts.
        /// </summary>
        /// <returns>List of contacts</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<ContactDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ContactDTO>>> GetAllContacts(CancellationToken cancellationToken = default)
        {
            try
            {
                var contacts = await _contactService.GetAllContactsAsync(cancellationToken);
                return Ok(contacts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving contacts.");
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal server error has occurred.");
            }
        }
    }
}

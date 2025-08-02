using Address_Book.DTOs;
using Address_Book.Services;
using Microsoft.AspNetCore.Mvc;

namespace Address_Book.Controllers
{
    [Route("")]
    [ApiController]
    [Produces("application/json")]
    public class ContactsController(IContactService contactService, ILogger<ContactsController> logger) : ControllerBase
    {
        private readonly IContactService _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
        private readonly ILogger<ContactsController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        /// <summary>
        /// Gets all the address book data
        /// </summary>
        /// <returns>List of contacts</returns>
        [HttpGet("contacts")]
        [ProducesResponseType(typeof(IEnumerable<ContactDTO>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ContactDTO>>> GetAllContacts()
        {
            try
            {
                var contacts = await _contactService.GetAllContactsAsync();
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

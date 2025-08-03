using Address_Book.DTOs;
using Address_Book.Services;
using Microsoft.AspNetCore.Mvc;

namespace Address_Book.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ContactsController(IContactService contactService, ILogger<ContactsController> logger) : ControllerBase
    {
        private readonly IContactService _contactService = contactService ?? throw new ArgumentNullException(nameof(contactService));
        private readonly ILogger<ContactsController> _logger = logger ?? throw new ArgumentNullException(nameof(logger));

        /// <summary>
        /// Get all contacts
        /// </summary>
        /// <returns>Address book data</returns>
        [HttpGet]
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

        /// <summary>
        /// Get contact by Id
        /// </summary>
        /// <param name="id">The unique identifier of the contact</param>
        /// <returns>Contact details including address info</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(ContactDTO), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ContactDTO>> GetContactById(int id)
        {
            try
            {
                var contact = await _contactService.GetContactByIdAsync(id);
                if (contact == null)
                {
                    _logger.LogWarning("Contact with ID {ContactId} not found.", id);
                    return NotFound($"Contact with ID {id} not found.");
                }
                return Ok(contact);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while retrieving contact with ID {ContactId}.", id);
                return StatusCode(StatusCodes.Status500InternalServerError, "An internal server error has occurred.");
            }
        }
    }
}

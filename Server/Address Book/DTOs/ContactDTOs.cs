using System.ComponentModel.DataAnnotations;

namespace Address_Book.DTOs
{
    public record ContactDTO
    (
        int Id,
        string FullName,
        string Email,
        string? PhoneNumber,
        string? Address,
        string? City,
        string? Province,
        string? ZipCode,
        DateTime CreatedAt,
        DateTime UpdatedAt
    );

    public record CreateContactDTO
    (
        [Required]
        [StringLength(100, MinimumLength = 1)]
        string FullName,

        [Required]
        [EmailAddress]
        [StringLength(100)]
        string Email,

        [Phone]
        [StringLength(15)]
        string? PhoneNumber,

        [StringLength(200)]
        string? Address,

        [StringLength(50)]
        string? City,

        [StringLength(50)]
        string? Province,

        [StringLength(10)]
        string? ZipCode
    );

    public record UpdateContactDTOs
    (
        [Required]
        [StringLength(100, MinimumLength = 1)]
        string FullName,

        [Required]
        [EmailAddress]
        [StringLength(100)]
        string Email,

        [Phone]
        [StringLength(15)]
        string? PhoneNumber,

        [StringLength(200)]
        string? Address,

        [StringLength(50)]
        string? City,

        [StringLength(50)]
        string? Province,

        [StringLength(10)]
        string? ZipCode
    );
}

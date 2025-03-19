using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Ticket : IValidatableObject
    {
        public Guid TicketGuid { get; set; } = Guid.NewGuid(); // Unique Identifier 
        public int Id { get; set; } // Primary Key
        public string TicketType { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")] public string? Username { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)] public string? UserContactNo { get; set; }

        [Required(ErrorMessage = "This field is required")][EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)] public string? UserEmail { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(200)] public string? SiteAddress { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)] public string? Make { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)] public string? Model { get; set; }

        // Template1 Fields -------------------------------------------------
        [StringLength(50)] public string? Number { get; set; }

        [StringLength(50)] public string? DesktopSerial { get; set; }

        [StringLength(200)] public string? Description { get; set; }

        // Template2 Fields -------------------------------------------------
        [EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)] public string? Email { get; set; }

        [StringLength(50)] public string? LaptopSerial { get; set; }

        [StringLength(50)] public string? LaptopMake { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TicketType == "Template1")
            {
                if (string.IsNullOrEmpty(Number))
                    yield return new ValidationResult("Number is required for Template 1", new[] { nameof(Number) });

                if (string.IsNullOrEmpty(DesktopSerial))
                    yield return new ValidationResult("Desktop Serial is required for Template 1", new[] { nameof(DesktopSerial) });

                if (string.IsNullOrEmpty(Description))
                    yield return new ValidationResult("Description is required for Template 1", new[] { nameof(Description) });
            }
            else if (TicketType == "Template2")
            {
                if (string.IsNullOrEmpty(Email))
                    yield return new ValidationResult("Email is required for Template 2", new[] { nameof(Email) });

                if (string.IsNullOrEmpty(LaptopSerial))
                    yield return new ValidationResult("Laptop Serial is required for Template 2", new[] { nameof(LaptopSerial) });

                if (string.IsNullOrEmpty(LaptopMake))
                    yield return new ValidationResult("Laptop Make is required for Template 2", new[] { nameof(LaptopMake) });
            }
        }
    }
}

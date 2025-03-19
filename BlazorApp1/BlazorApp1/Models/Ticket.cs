using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Ticket : IValidatableObject
    {
        public Guid TicketGuid { get; set; } = Guid.NewGuid(); // Unique Identifier 
        public int Id { get; set; } // Primary Key
        public string TicketType { get; set; }

        [Required(ErrorMessage = "Username is required")][StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")] public string? Username { get; set; }

        [Required(ErrorMessage = "User contact number is required")][StringLength(50)] public string? UserContactNo { get; set; }

        [Required(ErrorMessage = "Email address is required")][EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)] public string? UserEmail { get; set; }

        [Required(ErrorMessage = "Site address is required")][StringLength(200)] public string? SiteAddress { get; set; }

        [Required(ErrorMessage = "Device make is required")][StringLength(50)] public string? Make { get; set; }

        [Required(ErrorMessage = "Device model is required")][StringLength(50)] public string? Model { get; set; }

        // Template1 Fields -------------------------------------------------
        [StringLength(50)] public string? Number { get; set; }

        [StringLength(50)] public string? DesktopSerial { get; set; }

        [StringLength(200)] public string? Description { get; set; }

        // Template2 Fields -------------------------------------------------
        [EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)] public string? Email { get; set; }

        [StringLength(50)] public string? LaptopSerial { get; set; }

        [StringLength(50)] public string? LaptopMake { get; set; }

        // Template3 Fields -------------------------------------------------
        [StringLength(50)] public string? Template3Field1 { get; set; }

        [StringLength(50)] public string? Template3Field2 { get; set; }

        [StringLength(200)] public string? Template3Field3 { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TicketType == "Template1")
            {
                if (string.IsNullOrEmpty(Number))
                    yield return new ValidationResult("Number is required", new[] { nameof(Number) });

                if (string.IsNullOrEmpty(DesktopSerial))
                    yield return new ValidationResult("Desktop Serial is required", new[] { nameof(DesktopSerial) });

                if (string.IsNullOrEmpty(Description))
                    yield return new ValidationResult("Description is required", new[] { nameof(Description) });
            }
            else if (TicketType == "Template2")
            {
                if (string.IsNullOrEmpty(Email))
                    yield return new ValidationResult("Email is required", new[] { nameof(Email) });

                if (string.IsNullOrEmpty(LaptopSerial))
                    yield return new ValidationResult("Laptop Serial is required", new[] { nameof(LaptopSerial) });

                if (string.IsNullOrEmpty(LaptopMake))
                    yield return new ValidationResult("Laptop Make is required", new[] { nameof(LaptopMake) });
            }
            else if (TicketType == "Template3")
            {
                if (string.IsNullOrEmpty(Template3Field1))
                    yield return new ValidationResult("Template3Field1 is required", new[] { nameof(Template3Field1) });

                if (string.IsNullOrEmpty(Template3Field2))
                    yield return new ValidationResult("Template3Field2 is required", new[] { nameof(Template3Field2) });

                if (string.IsNullOrEmpty(Template3Field3))
                    yield return new ValidationResult("Template3Field3 is required", new[] { nameof(Template3Field3) });
            }
        }
    }
}

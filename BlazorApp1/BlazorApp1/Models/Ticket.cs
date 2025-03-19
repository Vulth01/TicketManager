using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Ticket
    {
        public Guid TicketGuid { get; set; } = Guid.NewGuid(); // Unique Identifier (for consistency)
        public int Id { get; set; } // Primary Key
        public string TicketType { get; set; }

        // Common fields shared between templates
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? CompanyName { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? CompanyTelNo { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? PrimeReporter { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? PrimeReporterContact { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(100)][EmailAddress(ErrorMessage = "Invalid email address format")]public string? PrimeReporterEmail { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? PurchaseOrderNumber { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")]public string? Username { get; set; }
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? UserContactNo { get; set; }

        [Required(ErrorMessage = "This field is required")][EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)]public string? UserEmail { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(200)]public string? SiteAddress { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? Make { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? Model { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? ProductID { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? SerialNumber { get; set; }

        public bool UnderWarranty { get; set; } = false;

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? WarrantyPackNumber { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(200)]public string? FaultDescription { get; set; }

        public bool PhysicalDamage { get; set; } = false;

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? Campus { get; set; }
        
        [Required(ErrorMessage = "This field is required")]public bool PrimaryContact { get; set; } = false;
        
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? TroubleshooterName { get; set; }
        
        [Required(ErrorMessage = "This field is required")][EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)]public string? TroubleshooterEmail { get; set; }
        
        [Required(ErrorMessage = "This field is required")][RegularExpression(@"^\d{10}$", ErrorMessage = "Troubleshooter Contact Number must be 10 digits.")][StringLength(10)]public string? TroubleshooterContactNumber { get; set; }
        
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? EquipmentMake { get; set; }
        
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? EquipmentModel { get; set; }
        
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? EquipmentProductNumber { get; set; }
        
        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? EquipmentSerialNumber { get; set; }



        // Template1 Fields -------------------------------------------------

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? Number { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? DesktopSerial { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(200)]public string? Description { get; set; }


        // Template2 Fields -------------------------------------------------

        [Required(ErrorMessage = "This field is required")][EmailAddress(ErrorMessage = "Invalid email address format")][StringLength(100)]public string? Email { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? LaptopSerial { get; set; }

        [Required(ErrorMessage = "This field is required")][StringLength(50)]public string? LaptopMake { get; set; }
    }
}

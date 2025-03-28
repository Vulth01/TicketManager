﻿using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class Ticket : IValidatableObject
    {
        public Guid TicketGuid { get; set; } = Guid.NewGuid();                                      // Unique Identifier 
        public int Id { get; set; }                                                                 // Primary Key
        public string TicketType { get; set; }

        [Required(ErrorMessage = "Username is required")]
        [StringLength(50, ErrorMessage = "Username cannot exceed 50 characters")]
        public string? Username { get; set; }                                                       //USERNAME

        [Required(ErrorMessage = "User contact number is required")]
        [StringLength(50)]
        public string? UserContactNo { get; set; }                                                  //CONTACT NO.

        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Invalid email address format")]
        [StringLength(100)]
        public string? UserEmail { get; set; }                                                      //EMAIL

        [Required(ErrorMessage = "Site address is required")]
        [StringLength(200)]
        public string? SiteAddress { get; set; }                                                    //ADDRESS

        [StringLength(200)]
        public string? Description { get; set; }                                                    //DESCRIPTION



        // LAPTOP REPAIR TEMPLATE -------------------------------------------------
        [StringLength(50)] public string? LaptopSerial { get; set; }
        [StringLength(50)] public string? LaptopMake { get; set; }
        [StringLength(50)] public string? LaptopModel { get; set; }


        // PRINTER REPAIR TEMPLATE -------------------------------------------------

        [StringLength(50)] public string? PrinterSerial { get; set; }
        [StringLength(50)] public string? PrinterMake { get; set; }
        [StringLength(50)] public string? PrinterModel { get; set; }

        // TEMPLATE 3 TEMPLATE.... YEAH -------------------------------------------------
        [StringLength(50)] public string? Template3Field1 { get; set; }

        [StringLength(50)] public string? Template3Field2 { get; set; }

        [StringLength(200)] public string? Template3Field3 { get; set; }



        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (TicketType == "LaptopRepair")
            {
                if (string.IsNullOrEmpty(LaptopSerial))
                    yield return new ValidationResult("Laptop Serial is required", new[] { nameof(LaptopSerial) });

                if (string.IsNullOrEmpty(LaptopMake))
                    yield return new ValidationResult("Laptop Serial is required", new[] { nameof(LaptopMake) });

                if (string.IsNullOrEmpty(LaptopModel))
                    yield return new ValidationResult("Description is required", new[] { nameof(LaptopModel) });
            }
            else if (TicketType == "PrinterRepair")
            {

                if (string.IsNullOrEmpty(PrinterSerial))
                    yield return new ValidationResult("Printer Serial is required", new[] { nameof(PrinterSerial) });

                if (string.IsNullOrEmpty(PrinterMake))
                    yield return new ValidationResult("Printer Make is required", new[] { nameof(PrinterMake) });

                if (string.IsNullOrEmpty(PrinterModel))
                    yield return new ValidationResult("Printer Model is required", new[] { nameof(PrinterModel) });

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

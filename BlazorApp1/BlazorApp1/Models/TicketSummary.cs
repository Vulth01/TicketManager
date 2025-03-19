namespace BlazorApp1.Models
{
    public class TicketSummary
    {
        // Basic fields for the summary view
        public Guid TicketGuid { get; set; } // Unique Identifier
        public int Id { get; set; } // Primary Key
        public string TicketType { get; set; } // Ticket Type (Template1, Template2)
        public string CompanyName { get; set; } // Company associated with the ticket
        public string CompanyTelNo { get; set; } // Company Telephone Number
        public string PrimeReporter { get; set; } // Prime reporter's name
        public string PrimeReporterContact { get; set; } // Prime reporter's contact number
        public string PrimeReporterEmail { get; set; } // Prime reporter's email address
        public string PurchaseOrderNumber { get; set; } // Purchase Order Number
        public string Username { get; set; } // User associated with the ticket
        public string UserContactNo { get; set; } // User's contact number
        public string UserEmail { get; set; } // User's email
        public string SiteAddress { get; set; } // Address related to the site
        public string Make { get; set; } // Equipment make
        public string Model { get; set; } // Equipment model
        public string ProductID { get; set; } // Product ID of the equipment
        public string SerialNumber { get; set; } // Equipment Serial Number
        public bool UnderWarranty { get; set; } // Whether it's under warranty or not
        public string WarrantyPackNumber { get; set; } // Warranty Pack Number
        public string FaultDescription { get; set; } // Fault description of the equipment
        public bool PhysicalDamage { get; set; } // Flag for physical damage
        public string Campus { get; set; } // Campus related to the ticket
        public bool PrimaryContact { get; set; } // Flag for primary contact
        public string TroubleshooterName { get; set; } // Troubleshooter's name
        public string TroubleshooterEmail { get; set; } // Troubleshooter's email
        public string TroubleshooterContactNumber { get; set; } // Troubleshooter's contact number
        public string EquipmentMake { get; set; } // Equipment's make
        public string EquipmentModel { get; set; } // Equipment's model
        public string EquipmentProductNumber { get; set; } // Equipment's product number
        public string EquipmentSerialNumber { get; set; } // Equipment's serial number
        public string Number { get; set; } // Ticket number (Template1 specific)
        public string DesktopSerial { get; set; } // Desktop serial number (Template1 specific)
        public string Description { get; set; } // Description (Template1 specific)
        public string Email { get; set; } // Email address (Template2 specific)
        public string LaptopSerial { get; set; } // Laptop serial number (Template2 specific)
        public string LaptopMake { get; set; } // Laptop make (Template2 specific)
    }
}

using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class TicketTemplate2_Details
    {
        // Unique identifier for the ticket (Optional, if needed for some purpose)
        public Guid TicketGuid { get; set; } = Guid.NewGuid();  // Default value set to a new GUID

        public int Id { get; set; }  // Primary key, typically auto-incremented in a database


        /*                  DOCUMENT-PROPERTIES            */                                       //  ---EXAMPLES---
        [StringLength(50)] public string CompanyName { get; set; }                       // Example: "Vega School"  
        [StringLength(50)] public string CompanyTelNo { get; set; }                      // Example: "021 461 8089"  
        [StringLength(50)] public string PrimeReporter { get; set; }                     // Example: "Orrin Wilson"  
        [StringLength(50)] public string PrimeReporterContact { get; set; }              // Example: "074 546 4722"  
        [StringLength(100)] public string PrimeReporterEmail { get; set; }               // Example: "owilson@vegaschool.com"  
        [StringLength(50)] public string PurchaseOrderNumber { get; set; }                          // Example: "PO123456"  
        [StringLength(50)] public string Username { get; set; }                          // Example: "Owilson"  
        [StringLength(50)] public string UserContactNo { get; set; }                     // Example: "074 546 4722"  
        [StringLength(100)] public string UserEmail { get; set; }                        // Example: "owilson@vegaschool.com"  
        [StringLength(200)] public string SiteAddress { get; set; }                      // Example: "130 Strand Street, De Waterkant, Cape Town"  
        [StringLength(50)] public string Make { get; set; }                              // Example: "HP"  
        [StringLength(50)] public string Model { get; set; }                             // Example: "255 G9"  
        [StringLength(50)] public string ProductID { get; set; }                         // Example: "6Q7Y7ES#ACQ"  
        [StringLength(50)] public string SerialNumber { get; set; }                      // Example: "CND2331YWD"  
        public bool UnderWarranty { get; set; }                                          // Example: true (Yes, under warranty)  
        [StringLength(50)] public string WarrantyPackNumber { get; set; }                           // Example: "WP123456"  
        [StringLength(200)] public string FaultDescription { get; set; }                            // Example: "The laptop hinge is flexing when opening the lid, causing the screen bezel to detach from its groove."  
        public bool PhysicalDamage { get; set; }                                         // Example: false (No physical damage)
    }
}

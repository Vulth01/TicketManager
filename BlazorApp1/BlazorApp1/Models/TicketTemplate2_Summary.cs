using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class TicketTemplate2_Summary
    {
        public Guid TicketGuid { get; set; }                                // Unique identifier for the ticket
        public int Id { get; set; }                                         // Primary key for the ticket

        /*              DOCUMENT-PROPERTIES             */                  //  ---EXAMPLES---
        public string CompanyName { get; set; }                             // Example: "Vega School"  
        public string CompanyTelNo { get; set; }                            // Example: "021 461 8089"  
        public string PrimeReporter { get; set; }                           // Example: "Orrin Wilson"  
        public string PrimeReporterContact { get; set; }                    // Example: "074 546 4722"  
        public string PrimeReporterEmail { get; set; }                      // Example: "owilson@vegaschool.com"  
        public string PurchaseOrderNumber { get; set; }                     // Example: "PO123456"  
        public string Username { get; set; }                                // Example: "Owilson"  
        public string UserContactNo { get; set; }                           // Example: "074 546 4722"  
        public string UserEmail { get; set; }                               // Example: "owilson@vegaschool.com"  
        public string SiteAddress { get; set; }                             // Example: "130 Strand Street, De Waterkant, Cape Town"  
        public string Make { get; set; }                                    // Example: "HP"  
        public string Model { get; set; }                                   // Example: "255 G9"  
        public string ProductID { get; set; }                               // Example: "6Q7Y7ES#ACQ"  
        public string SerialNumber { get; set; }                            // Example: "CND2331YWD"  
        public bool UnderWarranty { get; set; }                             // Example: true (Yes, under warranty)  
        public string WarrantyPackNumber { get; set; }                      // Example: "WP123456"  
        public string FaultDescription { get; set; }                        // Example: "The laptop hinge is flexing when opening the lid, causing the screen bezel to detach from its groove."  
        public bool PhysicalDamage { get; set; }                            // Example: false (No physical damage)
    }
}

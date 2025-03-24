namespace BlazorApp1.Models
{
    public class TicketSummary
    {
        // Basic fields for the summary view
        public Guid     TicketGuid      { get; set; }                                           // Unique Identifier
        public int      Id              { get; set; }                                           // Primary Key
        public string   TicketType      { get; set; }                                           // Template Option
        public string   Username        { get; set; }
        public string   UserContactNo   { get; set; }
        public string   UserEmail       { get; set; }
        public string   SiteAddress     { get; set; }
        public string   Description     { get; set; }


        //LAPTOP REPAIR
        public string   LaptopSerial    { get; set; }                                           
        public string   LaptopMake      { get; set; }                                             
        public string   LaptopModel     { get; set; }                                            


        //PRINTER REPAIR
        public string   PrinterSerial   { get; set; }                                          
        public string   PrinterMake     { get; set; }                                            
        public string   PrinterModel    { get; set; }                                           


        //TEMPLATE 3
        public string   Template3Field1 { get; set; }                                        
        public string   Template3Field2 { get; set; }                                        
        public string   Template3Field3 { get; set; }                                        

    }
}

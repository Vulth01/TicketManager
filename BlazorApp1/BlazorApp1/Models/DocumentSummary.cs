using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class DocumentSummary
    {

        public Guid guid { get; set; }
        public int Id { get; set; }


        /*                  WORD-DOCUMENT-PROPERTIES            */                  //---EXAMPLES---
        public string Brand { get; set; }                                           //Tertiary
        public string Campus { get; set; }                                          //Rosebank College Pretoria CBD
        public string UserName { get; set; }                                        //Sunnyboy Rasebeka
        public string UserEmail { get; set; }                                       //srasebeka@rosebankcollege.co.za
        public string UserContactNumber { get; set; }                               //060 582 9269
        public bool PrimaryContact { get; set; }                                    //Yes
        public string TroubleshooterName { get; set; }                              //Sunnyboy Rasebeka
        public string TroubleshooterEmail { get; set; }                             //srasebeka@rosebankcollege.co.za
        public string TroubleshooterContactNumber { get; set; }                     //012 320 7270
        public string SiteAddress { get; set; }                                     //239 Southern Life Building Cnr Pretorius and Thabo Sehume Pretoria CBD
        public string EquipmentMake { get; set; }                                   //HP
        public string EquipmentModel { get; set; }                                  //HP 255 G9
        public string EquipmentProductNumber { get; set; }                          //6Q7Y7ES
        public string EquipmentSerialNumber { get; set; }                           //CND3131JYG
        public string FaultDescription { get; set; }                                //Laptop fan is making noise when powered on. Kindly refer to the attached clip.



    }
}



        //-----HALO-SIDED-PROPERTIES-----
        /*
        public required string Name { get; set; }
        public decimal Price { get; set; }
        public DateOnly LastUpdated { get; set; }
        public bool Complete { get; set; }

        public required string Type { get; set; }
        public DateOnly DateCreated { get; set; }
        public required string Customer { get; set; }
        public required string Site { get; set; }
        public required string User { get; set; }
        public required string Summary { get; set; }
        public required string Status { get; set; }
        public required float SLATimeLeft { get; set; }
        public required string Priority { get; set; }
        public float TimeTaken { get; set; }
        public required string Agent { get; set; }
        public float TicketAge { get; set; }
        public string? WorkingHours { get; set; }
        public required string Team { get; set; }
        public DateOnly LastActionDate { get; set; }
        public string? Category { get; set; }
        public DateOnly DateClosed { get; set; }
        */
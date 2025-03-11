using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class DocumentDetails
    {
        public int Id { get; set; }


        /*                  WORD-DOCUMENT-PROPERTIES            */
        [Required][StringLength(30)] public required string Brand { get; set; }                                 //Tertiary
        [Required][StringLength(30)] public required string Campus { get; set; }                                //Rosebank College Pretoria CBD
        [Required][StringLength(30)] public required string UserName { get; set; }                              //Sunnyboy Rasebeka
        [EmailAddress(ErrorMessage = "Invalid email format.")][Required][StringLength(30)]public required string UserEmail { get; set; }                              //srasebeka@rosebankcollege.co.za
        [RegularExpression(@"^\d{10}$")][Required][StringLength(10)]public required string UserContactNumber { get; set; }                      //060 582 9269
        [Required]public bool PrimaryContact { get; set; }                                                      //Yes
        [Required][StringLength(30)]public required string TroubleshooterName { get; set; }                     //Sunnyboy Rasebeka
        [EmailAddress(ErrorMessage = "Invalid email format.")][Required][StringLength(30)]public required string TroubleshooterEmail { get; set; }                    //srasebeka@rosebankcollege.co.za
        [RegularExpression(@"^\d{10}$")][Required][StringLength(10)]public required string TroubleshooterContactNumber { get; set; }            //012 320 7270
        [Required][StringLength(50)]public required string SiteAddress { get; set; }                            //239 Southern Life Building Cnr Pretorius and Thabo Sehume Pretoria CBD
        [Required][StringLength(30)]public required string EquipmentMake { get; set; }                          //HP
        [Required][StringLength(30)]public required string EquipmentModel { get; set; }                         //HP 255 G9
        [Required][StringLength(20)]public required string EquipmentProductNumber { get; set; }                 //6Q7Y7ES
        [Required][StringLength(20)]public required string EquipmentSerialNumber { get; set; }                  //CND3131JYG
        [Required][StringLength(100)]public required string FaultDescription { get; set; }                      //Laptop fan is making noise when powered on. Kindly refer to the attached clip.



    }
}



//HALO-SIDED-PROPERTIES
/*
[Required]
[StringLength(50)]
public required string Name { get; set; }
[Range(1, 100)]
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
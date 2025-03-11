using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.Models
{
    public class DocumentDetails
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Name { get; set; }


        [Range(1, 100)]
        public decimal Price { get; set; }

        public DateOnly LastUpdated { get; set; }

        public bool Complete { get; set; }



        //TICKET-MANAGER-PROPERTIES

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


    }
}

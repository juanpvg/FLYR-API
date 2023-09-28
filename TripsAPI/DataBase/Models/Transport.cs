using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripsDb.Models
{
    public class Transport
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int TransportId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string FlightCarrier { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string FlightNumber { get; set; } = "";

    }
}

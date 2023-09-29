using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TripsDb.Models
{
    public class Flight
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int FlightId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Origin { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Destination { get; set; } = "";

        [Column(TypeName = "decimal(19, 4)")]
        public double Price { get; set; }

        [ForeignKey("TransportId")]
        public virtual required Transport Transport { get; set; }

        public int TransportId { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripsDb.Models
{
    public class Journey
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(TypeName = "int")]
        public int JourneyId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Origin { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string Destination { get; set; } = "";

        [Column(TypeName = "decimal(19, 4)")]
        public double Price { get; set; }

        public ICollection<Flight> Flights { get; } = new List<Flight>();

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripsDb.Models
{
    public class Journey
    {

        public string Origin { get; set; } = "";

        public string Destination { get; set; } = "";

        public double Price { get; set; }


    }
}

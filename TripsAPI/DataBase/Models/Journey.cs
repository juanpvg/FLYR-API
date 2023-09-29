using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TripsDb.Models
{
    public class Journey
    {

        public string Origin { get; set; } = "";

        public string Destination { get; set; } = "";

        public double Price { get; set; } = 0;

        public List<Flight> Flights { get; set; } = new List<Flight>();

        public void addFlight(Flight flight) { 
            this.Flights.Add(flight);
            this.Price = this.Price + flight.Price;
        }
    }
}

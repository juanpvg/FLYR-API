using TripsDb.Models;

namespace TripsRestAPI.Utilities
{
    public class FlightMapper
    {
        public Flight MapAndStore(ApiFlight apiFlight)
        {
            var transport = new Transport();
            transport.FlightCarrier = apiFlight.FlightCarrier;
            transport.FlightNumber = apiFlight.FlightNumber;
               
            return new Flight
            {
                Origin = apiFlight.DepartureStation,
                Destination = apiFlight.ArrivalStation,
                Price = apiFlight.Price,
                Transport = transport
            };
        }

        public List<Flight> MapAndStore(List<ApiFlight> apiFlights)
        {
            return apiFlights.Select(MapAndStore).ToList();
        }
    }
}

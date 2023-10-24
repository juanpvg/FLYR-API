using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TripsDb.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TripsRestAPI.Utilities
{
    public class FlightMapper
    {
        private TripsDbContext _context;

        public FlightMapper(TripsDbContext context)
        {
            _context = context;
        }
        public Flight MapAndStore(ApiFlight apiFlight)
        {
        {
            Transport transport = addTransport(apiFlight);
            Flight newFlight = addFlight(apiFlight, transport);
            return newFlight;

        }

        public Transport addTransport(ApiFlight apiFlight)
        {
            var transport = new Transport();
            transport.FlightCarrier = apiFlight.FlightCarrier;
            transport.FlightNumber = apiFlight.FlightNumber;
            _context.Transport.Add(transport);
            _context.SaveChanges();
            return transport;
        }

        public Flight addFlight(ApiFlight apiFlight, Transport transport)
        {
            var newFlight = new Flight
            {
                Origin = apiFlight.DepartureStation,
                Destination = apiFlight.ArrivalStation,
                Price = apiFlight.Price,
                Transport = transport,
            };
            _context.Flight.Add(newFlight);
            _context.SaveChanges();
            return newFlight;
        }

        public List<Flight> MapAndStore(List<ApiFlight> apiFlights)
        {
            return apiFlights.Select(MapAndStore).ToList();
        }
    }
}

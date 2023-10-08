using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripsDb.Models;

using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Text;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using TripsRestAPI.Utilities;
using System.Collections.Generic;

namespace TripsRestAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class JourneyController : ControllerBase
    {
        private TripsDbContext _context;

        public JourneyController(TripsDbContext context)
        {
            _context = context;
        }




        [HttpGet]
        public async Task<List<Journey>>  Get(string origin, String destination)
        {
            if (origin == null || destination == null) { 
                return new List<Journey>();
            }

            var flights = _context.Flight.ToList();

            if(flights.IsNullOrEmpty() )
            {
                var apiFlights = await FlightUtilities.getMultipleReturnFlightsFromApi();
                flights = new FlightMapper(_context).MapAndStore(apiFlights);
            }

            var pathFinder = new FlightPathFinder(flights);
            var journeys = pathFinder.FindAllPaths(origin, destination);

            return journeys;
 
        }

   

    }
}

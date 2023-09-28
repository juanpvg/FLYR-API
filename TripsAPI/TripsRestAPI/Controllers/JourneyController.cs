using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripsDb.Models;

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
        public IEnumerable<Journey> Get() {
            var journeys =  _context.Journey.ToList();

            if (journeys.Count != 0) {
                return journeys;
            }

            // Get journeys from third party URL
            // add Journeys to DB
            // return Journeys
            return journeys;
        }
    }
}

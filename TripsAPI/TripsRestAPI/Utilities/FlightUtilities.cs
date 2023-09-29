using Newtonsoft.Json;
using TripsDb.Models;

namespace TripsRestAPI.Utilities
{
    public class FlightUtilities
    {
        public static async Task<List<ApiFlight>> getUnikeFlightsFromApi()
        {
            var apiBaseUrl = "https://recruiting-api.newshore.es/api/flights/0";
            var client = new FlightApiClient(apiBaseUrl);
            var flights = await client.GetFlightsAsync();
            return flights.ToList();
        }

        public static async Task<List<ApiFlight>> getMultipleReturnFlightsFromApi()
        {
            var apiBaseUrl = "https://recruiting-api.newshore.es/api/flights/2";
            var client = new FlightApiClient(apiBaseUrl);
            var flights = await client.GetFlightsAsync();
            return flights.ToList();
        }
    }
}

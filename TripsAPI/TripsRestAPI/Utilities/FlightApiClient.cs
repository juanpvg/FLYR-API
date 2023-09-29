using Newtonsoft.Json;
using TripsDb.Models;

namespace TripsRestAPI.Utilities
{

    public class FlightApiClient
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        public FlightApiClient(string baseUrl)
        {
            httpClient = new HttpClient();
            apiUrl = baseUrl;
        }

        public async Task<List<ApiFlight>> GetFlightsAsync()
        {
            try
            {
                var response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var flights = JsonConvert.DeserializeObject<List<ApiFlight>>(json);
                    return flights;
                }
                else
                {
                    Console.WriteLine($"Failed to fetch data. Status code: {response.StatusCode}");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return null;
            }
        }
    }
}

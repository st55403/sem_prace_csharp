using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WpfApp1.Services.API.Models;

namespace WpfApp1.Services.API
{
    public class SpaceXService : ISpaceXService
    {
        public async Task<IEnumerable<ParsedLaunch>> GetAllLaunches()
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://api.spacexdata.com/v3/launches";
                HttpResponseMessage apiResponse = await client.GetAsync(uri);
                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<APILaunch> apiLaunches = JsonSerializer.Deserialize<List<APILaunch>>(jsonResponse);

                return apiLaunches.Select(apiLaunch => new ParsedLaunch()
                {
                    flight_number= apiLaunch.flight_number,
                    mission_name= apiLaunch.mission_name,
                    upcoming= apiLaunch.upcoming,
                    launch_date_utc= apiLaunch.launch_date_utc,
                    launch_success= apiLaunch.launch_success,
                    details= apiLaunch.details,
                    rocket_id= apiLaunch.rocket.rocket_id,
                    rocket_name= apiLaunch.rocket.rocket_name,
                    rocket_type= apiLaunch.rocket.rocket_type
                });
            }
        }

        public async Task<IEnumerable<ParsedShip>> GetAllShips()
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://api.spacexdata.com/v3/ships";
                HttpResponseMessage apiResponse = await client.GetAsync(uri);
                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<APIShip> apiShips = JsonSerializer.Deserialize<List<APIShip>>(jsonResponse);

                return apiShips.Select(apiShip => new ParsedShip() 
                {
                    ship_id= apiShip.ship_id,
                    home_port= apiShip.home_port,
                    year_built= apiShip.year_built,
                    status= apiShip.status,
                    missions = apiShip.missions
                });
            }
        }
    }
}

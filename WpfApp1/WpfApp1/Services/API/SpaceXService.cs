using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Services.API.Models;

namespace WpfApp1.Services.API
{
    public class SpaceXService : ISpaceXService
    {
        public async Task<IEnumerable<Launch>> GetAllLaunches()
        {
            using (HttpClient client = new HttpClient())
            {
                string uri = "https://api.spacexdata.com/v3/launches";
                HttpResponseMessage apiResponse = await client.GetAsync(uri);
                string jsonResponse = await apiResponse.Content.ReadAsStringAsync();

                List<APILaunch> apiLaunches = JsonSerializer.Deserialize<List<APILaunch>>(jsonResponse);

                return apiLaunches.Select(apiLaunch => new Launch(
                    apiLaunch.details,
                    apiLaunch.flight_number.ToString(),
                    apiLaunch.launch_date_utc,
                    apiLaunch.launch_success.ToString(),
                    apiLaunch.mission_name,
                    apiLaunch.upcoming.ToString()
                    ));
            }
        }
    }
}

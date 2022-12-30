using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.LaunchProviders
{
    public interface ILaunchProvider
    {
        Task<IEnumerable<Launch>> GetAllLaunches();
    }
}

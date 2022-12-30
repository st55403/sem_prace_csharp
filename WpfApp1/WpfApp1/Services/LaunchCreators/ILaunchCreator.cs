using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.LaunchCreators
{
    public interface ILaunchCreator
    {
        Task AddLaunch(Launch launch);
        Task AddLaunchShip(LaunchShip launchShip);
        Task UpdateLaunch(Launch launch);
    }
}

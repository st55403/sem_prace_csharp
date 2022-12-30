using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.RocketCreators
{
    public interface IRocketCreator
    {
        Task CreateRocket(Rocket rocket);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.RocketProviders
{
    public interface IRocketProvider
    {
        Task<IEnumerable<Rocket>> GetAllRockets();
    }
}

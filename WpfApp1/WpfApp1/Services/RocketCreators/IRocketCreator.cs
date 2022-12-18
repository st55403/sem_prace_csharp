using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.Services.RocketCreators
{
    public interface IRocketCreator
    {
        Task CreateRocket(Rocket rocket);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    public class LoadRocketsCommand : AsyncCommandBase
    {
        private RocketListViewModel rocketListViewModel;
        private Company company;

        public LoadRocketsCommand(RocketListViewModel rocketListViewModel, Company company)
        {
            this.rocketListViewModel = rocketListViewModel;
            this.company = company;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<Rocket> rockets = await company.GetAllRockets();
            rocketListViewModel.UpdateRockets(rockets);
        }
    }
}

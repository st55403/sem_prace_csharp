using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    public class LoadLaunchesCommand : AsyncCommandBase
    {
        private LaunchesListViewModel launchesListViewModel;
        private Company company;

        public LoadLaunchesCommand(LaunchesListViewModel launchesListViewModel, Company company)
        {
            this.launchesListViewModel = launchesListViewModel;
            this.company = company;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<Launch> launches = await company.GetAllLaunches();
            launchesListViewModel.UpdateLaunches(launches);
        }
    }
}

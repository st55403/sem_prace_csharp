using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class AddLaunchCommand : AsyncCommandBase
    {
        private readonly AddLaunchViewModel addLaunchViewModel;
        private readonly Company company;
        private readonly NavigationService navigationServiceToLaunchesList;

        public AddLaunchCommand(
            AddLaunchViewModel addLaunchViewModel, 
            Company company, 
            NavigationService navigationServiceToLaunchesList)
        {
            this.addLaunchViewModel = addLaunchViewModel;
            this.company = company;
            this.navigationServiceToLaunchesList = navigationServiceToLaunchesList;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            navigationServiceToLaunchesList.Navigate();
        }
    }
}

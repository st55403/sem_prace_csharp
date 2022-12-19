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
    class AddShipCommand : AsyncCommandBase
    {
        private readonly AddShipViewModel addShipViewModel;
        private readonly Company company;
        private readonly NavigationService navigationServiceToShipsList;

        public AddShipCommand(
            AddShipViewModel addShipViewModel, 
            Company company, 
            NavigationService navigationServiceToShipsList)
        {
            this.addShipViewModel = addShipViewModel;
            this.company = company;
            this.navigationServiceToShipsList = navigationServiceToShipsList;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            navigationServiceToShipsList.Navigate();
        }
    }
}

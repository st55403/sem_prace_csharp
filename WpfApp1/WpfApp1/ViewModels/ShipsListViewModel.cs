using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    class ShipsListViewModel : ViewModelBase
    {
        public ICommand AddShipCommand { get; }
        public ICommand BackCommand { get; }
        public ShipsListViewModel(
            Company company, 
            NavigationService navigationServiceToAddShip,
            NavigationService navigationServiceToCompanyInfo)
        {
            AddShipCommand = new NavigateCommandToAddShip(navigationServiceToAddShip);
            BackCommand = new NavigateCommandToCompanyInfo(navigationServiceToCompanyInfo);
        }
    }
}

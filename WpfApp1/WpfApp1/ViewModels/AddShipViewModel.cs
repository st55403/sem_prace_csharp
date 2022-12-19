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
    class AddShipViewModel : ViewModelBase
    {
        public ICommand AddCommand { get; }

        public ICommand CancelCommand { get; }

        public AddShipViewModel(
            Company company,
            NavigationService navigationServiceAddShip)
        {
            AddCommand = new AddShipCommand(this, company, navigationServiceAddShip);
            CancelCommand = new NavigateCommandToShipsList(navigationServiceAddShip);
        }
    }
}

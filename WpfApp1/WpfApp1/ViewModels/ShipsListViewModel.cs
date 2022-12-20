using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class ShipsListViewModel : ViewModelBase
    {
        private ObservableCollection<ShipViewModel> _ships;
        public IEnumerable<ShipViewModel> Ships => _ships;

        public ICommand LoadShipsCommand { get; }
        public ICommand AddShipCommand { get; }
        public ICommand BackCommand { get; }
        public ShipsListViewModel(
            Company company, 
            NavigationService navigationServiceToAddShip,
            NavigationService navigationServiceToCompanyInfo)
        {
            _ships = new ObservableCollection<ShipViewModel>();
            LoadShipsCommand = new LoadShipsCommand(this, company);
            AddShipCommand = new NavigateCommandToAddShip(navigationServiceToAddShip);
            BackCommand = new NavigateCommandToCompanyInfo(navigationServiceToCompanyInfo);
        }

        public static ShipsListViewModel LoadViewModel(
            Company company,
            NavigationService navigationServiceToAddShip,
            NavigationService navigationServiceToCompanyInfo)
        {
            ShipsListViewModel viewModel = new ShipsListViewModel(
                company, 
                navigationServiceToAddShip, 
                navigationServiceToCompanyInfo);
            viewModel.LoadShipsCommand.Execute(null);
            return viewModel;
        }

        public void UpdateShips(IEnumerable<Ship> ships)
        {
            _ships.Clear();
            foreach (Ship sh in ships)
            {
                ShipViewModel shipViewModel = new ShipViewModel(sh);
                _ships.Add(shipViewModel);
            }
        }
    }
}

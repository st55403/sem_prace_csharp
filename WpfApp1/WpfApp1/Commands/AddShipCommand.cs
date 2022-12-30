using System.ComponentModel;
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
            addShipViewModel.PropertyChanged += OnViewModelPropertyChange;
        }

        private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AddShipViewModel.ShipId) ||
                e.PropertyName == nameof(AddShipViewModel.HomePort) ||
                e.PropertyName == nameof(AddShipViewModel.Status) ||
                e.PropertyName == nameof(AddShipViewModel.YearOfBuild))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(addShipViewModel.ShipId) &&
                !string.IsNullOrEmpty(addShipViewModel.HomePort) &&
                !string.IsNullOrEmpty(addShipViewModel.Status) &&
                !string.IsNullOrEmpty(addShipViewModel.YearOfBuild) &&
                base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // todo og consider remove missions filed
            Ship ship = new Ship(addShipViewModel.ShipId, addShipViewModel.HomePort, addShipViewModel.YearOfBuild, addShipViewModel.Status, "");
            await company.AddShip(ship);
            navigationServiceToShipsList.Navigate();
        }

    }
}

using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    class AddShipViewModel : ViewModelBase
    {
        private string shipId;
        public string ShipId
        {
            get
            {
                return shipId;
            }
            set
            {
                shipId = value;
                OnPropertyChanged(nameof(ShipId));
            }
        }

        private string homePort;
        public string HomePort
        {
            get
            {
                return homePort;
            }
            set
            {
                homePort = value;
                OnPropertyChanged(nameof(HomePort));
            }
        }

        private string yearOfBuild;
        public string YearOfBuild
        {
            get
            {
                return yearOfBuild;
            }
            set
            {
                yearOfBuild = value;
                OnPropertyChanged(nameof(YearOfBuild));
            }
        }

        private string status;
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
                OnPropertyChanged(nameof(Status));
            }
        }

        private string mission;
        public string Mission
        {
            get
            {
                return mission;
            }
            set
            {
                mission = value;
                OnPropertyChanged(nameof(Mission));
            }
        }
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

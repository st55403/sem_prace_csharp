using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class ShipViewModel : ViewModelBase
    {
        private Ship ship;

        public string ShipId => ship.ShipId;
        public string HomePort => ship.HomePort;
        public string YearOfBuild => ship.YearOfBuild;
        public string Status => ship.Status;
        public string Mission => ship.Mission;

        public ShipViewModel(Ship ship)
        {
            this.ship = ship;
        }
    }
}

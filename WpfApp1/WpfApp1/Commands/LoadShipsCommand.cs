using System.Collections.Generic;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    public class LoadShipsCommand : AsyncCommandBase
    {
        private ShipsListViewModel shipsListViewModel;
        private Company company;

        public LoadShipsCommand(ShipsListViewModel shipsListViewModel, Company company)
        {
            this.shipsListViewModel = shipsListViewModel;
            this.company = company;
        }

        public override async Task ExecuteAsync(object parameter)
        {
            IEnumerable<Ship> ships = await company.GetAllShips();
            shipsListViewModel.UpdateShips(ships);
        }
    }
}

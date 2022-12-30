using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    class CompanyInfoViewModel : ViewModelBase
    {
        public ICommand RocketsCommand { get; }
        public ICommand LaunchesCommand { get; }
        public ICommand ShipsCommand { get; }
        public ICommand FetchData { get; }
        public CompanyInfoViewModel(
            Company company, 
            NavigationService navigateRocketList, 
            NavigationService navigateLaunchesList, 
            NavigationService navigateShipsList)
        {
            RocketsCommand = new ShowRocketsCommand(this, company, navigateRocketList);
            LaunchesCommand = new ShowLaunchesCommand(this, company, navigateLaunchesList);
            ShipsCommand = new ShowShipsCommand(this, company, navigateShipsList);
            FetchData = new FetchAPIData(company);
        }
    }
}

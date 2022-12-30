using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToShipsList : CommandBase
    {
        private NavigationService navigationService;

        public NavigateCommandToShipsList(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

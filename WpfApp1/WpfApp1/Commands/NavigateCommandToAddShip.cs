using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToAddShip : CommandBase
    {
        private readonly NavigationService navigationService;

        public NavigateCommandToAddShip(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

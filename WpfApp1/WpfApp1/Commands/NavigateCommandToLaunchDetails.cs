using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToLaunchDetails : CommandBase
    {
        private readonly NavigationService navigationService;

        public NavigateCommandToLaunchDetails(NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

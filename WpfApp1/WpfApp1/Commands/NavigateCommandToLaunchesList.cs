using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToLaunchesList : CommandBase
    {
        private NavigationService navigationService;

        public NavigateCommandToLaunchesList(NavigationService navigationServiceAddLaunch)
        {
            this.navigationService = navigationServiceAddLaunch;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

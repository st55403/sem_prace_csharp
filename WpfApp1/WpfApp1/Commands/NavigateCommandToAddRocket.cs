using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToAddRocket : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateCommandToAddRocket(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}

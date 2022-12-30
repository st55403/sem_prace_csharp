using WpfApp1.Services;

namespace WpfApp1.Commands
{
    class NavigateCommandToCompanyInfo : CommandBase
    {
        private readonly NavigationService _navigationService;

        public NavigateCommandToCompanyInfo(NavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}

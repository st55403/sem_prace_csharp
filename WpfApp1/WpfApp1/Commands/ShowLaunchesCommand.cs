using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class ShowLaunchesCommand : CommandBase
    {
        private NavigationService navigationService;

        public ShowLaunchesCommand(CompanyInfoViewModel companyInfoViewModel, Company company, NavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WpfApp1.Services;
using System.Threading.Tasks;

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

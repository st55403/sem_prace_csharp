using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

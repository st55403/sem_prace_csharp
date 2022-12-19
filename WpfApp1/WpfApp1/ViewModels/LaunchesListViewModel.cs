using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.Stores;

namespace WpfApp1.ViewModels
{
    class LaunchesListViewModel : ViewModelBase
    {
        public ICommand AddLaunchCommand { get; }
        public ICommand BackCommand { get; }
        public LaunchesListViewModel(
            Company company, 
            NavigationService addRocketNavigationService, 
            NavigationService navigateToCompanyInfo)
        {
            AddLaunchCommand = new NavigateCommandToAddRocket(addRocketNavigationService);

            BackCommand = new NavigateCommandToCompanyInfo(navigateToCompanyInfo);
        }
    }
}

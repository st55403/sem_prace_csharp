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
    public class LaunchesListViewModel : ViewModelBase
    {
        private ObservableCollection<LaunchViewModel> _launches;

        public IEnumerable<LaunchViewModel> Launches => _launches;
        public ICommand LoadLaunchesCommand { get; }
        public ICommand AddLaunchCommand { get; }
        public ICommand DetailsLaunchCommand { get; }
        public ICommand BackCommand { get; }
        public LaunchesListViewModel(
            Company company, 
            NavigationService navigationServiceToAddLaunch, 
            NavigationService navigationServiceToCompanyInfo,
            NavigationService navigationServiceToLaunchDetails)
        {
            _launches = new ObservableCollection<LaunchViewModel>();
            LoadLaunchesCommand = new LoadLaunchesCommand(this, company);
            AddLaunchCommand = new NavigateCommandToAddRocket(navigationServiceToAddLaunch);
            BackCommand = new NavigateCommandToCompanyInfo(navigationServiceToCompanyInfo);
            DetailsLaunchCommand = new NavigateCommandToLaunchDetails(navigationServiceToLaunchDetails);
        }

        public static LaunchesListViewModel LoadViewModel(
            Company company,
            NavigationService navigationServiceToAddLaunch,
            NavigationService navigationServiceToCompanyInfo,
            NavigationService navigationServiceToLaunchDetails)
        {
            LaunchesListViewModel viewModel = new LaunchesListViewModel(
                company, 
                navigationServiceToAddLaunch,
                navigationServiceToCompanyInfo,
                navigationServiceToLaunchDetails);
            viewModel.LoadLaunchesCommand.Execute(null);
            return viewModel;
        }

        public void UpdateLaunches(IEnumerable<Launch> launches)
        {
            _launches.Clear();
            foreach (Launch la in launches)
            {
                LaunchViewModel launchViewModel = new LaunchViewModel(la);
                _launches.Add(launchViewModel);
            }
        }
    }
}

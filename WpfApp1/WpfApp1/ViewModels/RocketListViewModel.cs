using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    public class RocketListViewModel : ViewModelBase
    {
        private ObservableCollection<RocketViewModel> _rockets;   

        public IEnumerable<RocketViewModel> Rockets => _rockets;

        public ICommand LoadRocketsCommand { get;}
        public ICommand AddRocketCommand { get; }
        public ICommand BackCommand { get; }

        public RocketListViewModel(Company company, NavigationService addRocketNavigationService, NavigationService navigateToCompanyInfo)
        {
            _rockets= new ObservableCollection<RocketViewModel>();

            LoadRocketsCommand = new LoadRocketsCommand(this, company);

            AddRocketCommand = new NavigateCommandToAddRocket(addRocketNavigationService);

            BackCommand = new NavigateCommandToCompanyInfo(navigateToCompanyInfo);

        }

        public static RocketListViewModel LoadViewModel(Company company, NavigationService addRocketNavigationService, NavigationService navigateToCompanyInfo)
        {
            RocketListViewModel viewModel = new RocketListViewModel(company, addRocketNavigationService, navigateToCompanyInfo);
            viewModel.LoadRocketsCommand.Execute(null);
            return viewModel;
        }

        public void UpdateRockets(IEnumerable<Rocket> rockets)
        {
            _rockets.Clear();
            foreach (Rocket rocket in rockets)
            {
                RocketViewModel rocketViewModel = new RocketViewModel(rocket);
                _rockets.Add(rocketViewModel);
            }
        }
    }
}

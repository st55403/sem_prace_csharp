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
    public class RocketListViewModel : ViewModelBase
    {
        private ObservableCollection<RocketViewModel> _rockets;   

        public IEnumerable<RocketViewModel> Rockets => _rockets;

        public ICommand LoadRocketsCommand { get;}
        public ICommand AddRocketCommand { get; }

        public RocketListViewModel(Company company, NavigationService addRocketNavigationService)
        {
            _rockets= new ObservableCollection<RocketViewModel>();

            LoadRocketsCommand = new LoadRocketsCommand(this, company);

            AddRocketCommand = new NavigateCommandToAddRocket(addRocketNavigationService);;
        }

        public static RocketListViewModel LoadViewModel(Company company, NavigationService addRocketNavigationService)
        {
            RocketListViewModel viewModel = new RocketListViewModel(company, addRocketNavigationService);
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

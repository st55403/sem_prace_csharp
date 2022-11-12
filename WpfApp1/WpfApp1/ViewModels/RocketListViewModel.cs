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
    class RocketListViewModel : ViewModelBase
    {
        private Company _company;
        private ObservableCollection<RocketViewModel> _rockets;   

        public IEnumerable<RocketViewModel> Rockets => _rockets;
        public ICommand AddRocketCommand { get; }

        public RocketListViewModel(Company company, NavigationService addRocketNavigationService)
        {
            _company = company;
            _rockets= new ObservableCollection<RocketViewModel>();

            AddRocketCommand = new NavigateCommandToAddRocket(addRocketNavigationService);

            UpdateRockets();
        }

        private void UpdateRockets()
        {
            _rockets.Clear();
            foreach (Rocket rocket in _company.GetAllRockets())
            {
                RocketViewModel rocketViewModel = new RocketViewModel(rocket);
                _rockets.Add(rocketViewModel);
            }
        }
    }
}

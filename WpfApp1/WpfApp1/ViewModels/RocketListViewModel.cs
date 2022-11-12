using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class RocketListViewModel : ViewModelBase
    {
        private ObservableCollection<RocketViewModel> _rockets;   

        public IEnumerable<RocketViewModel> Rockets => _rockets;
        public ICommand AddRocketCommand { get; }

        public RocketListViewModel()
        {
            _rockets= new ObservableCollection<RocketViewModel>();

            AddRocketCommand = new NavigateCommandToAddRocket();

            _rockets.Add(new RocketViewModel(new Rocket("Falcone 1", "1", new Engine(1, "Single"))));
            _rockets.Add(new RocketViewModel(new Rocket("Falcone 2", "1", new Engine(1, "Single"))));
            _rockets.Add(new RocketViewModel(new Rocket("Falcone 3", "1", new Engine(1, "Single"))));
            _rockets.Add(new RocketViewModel(new Rocket("Falcone 4", "1", new Engine(1, "Single"))));
        }
    }
}

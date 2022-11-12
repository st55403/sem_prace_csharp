using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public ViewModelBase CurrentViewModel { get; set; }

        public MainViewModel(Company company)
        {
            CurrentViewModel = new RocketListViewModel();
            //CurrentViewModel = new AddRocketViewModel(company);
        }
    }
}

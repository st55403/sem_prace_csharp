using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    class AddLaunchViewModel : ViewModelBase
    {
        public ICommand AddCommand { get; }

        public ICommand CancelCommand { get; }

        public AddLaunchViewModel(
            Company company,
            NavigationService navigationServiceAddLaunch)
        {
            AddCommand = new AddLaunchCommand(this, company, navigationServiceAddLaunch);
            CancelCommand = new NavigateCommandToLaunchesList(navigationServiceAddLaunch);
        }
    }
}

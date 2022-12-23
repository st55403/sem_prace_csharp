using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class AddLaunchCommand : AsyncCommandBase
    {
        private readonly AddLaunchViewModel addLaunchViewModel;
        private readonly Company company;
        private readonly NavigationService navigationServiceToLaunchesList;

        public AddLaunchCommand(
            AddLaunchViewModel addLaunchViewModel, 
            Company company, 
            NavigationService navigationServiceToLaunchesList)
        {
            this.addLaunchViewModel = addLaunchViewModel;
            this.company = company;
            this.navigationServiceToLaunchesList = navigationServiceToLaunchesList;
            addLaunchViewModel.PropertyChanged += OnViewModelPropertyChange;
        }

        private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AddLaunchViewModel.Details) ||
                e.PropertyName == nameof(AddLaunchViewModel.LaunchSuccess) ||
                e.PropertyName == nameof(AddLaunchViewModel.Upcoming) ||
                e.PropertyName == nameof(AddLaunchViewModel.FlightNumber) ||
                e.PropertyName == nameof(AddLaunchViewModel.LaunchDateUtc) ||
                e.PropertyName == nameof(AddLaunchViewModel.MissionName))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return 
                !string.IsNullOrEmpty(addLaunchViewModel.Details) &&
                !string.IsNullOrEmpty(addLaunchViewModel.LaunchSuccess) &&
                !string.IsNullOrEmpty(addLaunchViewModel.Upcoming) &&
                !string.IsNullOrEmpty(addLaunchViewModel.FlightNumber) &&
                !string.IsNullOrEmpty(addLaunchViewModel.LaunchDateUtc) &&
                !string.IsNullOrEmpty(addLaunchViewModel.MissionName) &&
                base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            Launch launch = new Launch(addLaunchViewModel.Details, addLaunchViewModel.FlightNumber, addLaunchViewModel.LaunchDateUtc, addLaunchViewModel.LaunchSuccess, addLaunchViewModel.MissionName, addLaunchViewModel.Upcoming);
            await company.AddLaunch(launch);
            navigationServiceToLaunchesList.Navigate();
        }
    }
}

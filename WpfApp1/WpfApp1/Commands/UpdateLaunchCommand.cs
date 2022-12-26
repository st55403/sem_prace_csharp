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
    class UpdateLaunchCommand : AsyncCommandBase
    {
        private readonly LanuchDetailsViewModel lanuchDetailsViewModel;
        private readonly Company company;
        private readonly NavigationService navigationService;

        public UpdateLaunchCommand(
            LanuchDetailsViewModel lanuchDetailsViewModel, 
            Company company, 
            NavigationService navigationService)
        {
            this.lanuchDetailsViewModel = lanuchDetailsViewModel;
            this.company = company;
            this.navigationService = navigationService;
            lanuchDetailsViewModel.PropertyChanged += OnViewModelPropertyChange;
        }

        private void OnViewModelPropertyChange(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(LanuchDetailsViewModel.Details) ||
                e.PropertyName == nameof(LanuchDetailsViewModel.LaunchSuccess) ||
                e.PropertyName == nameof(LanuchDetailsViewModel.Upcoming) ||
                e.PropertyName == nameof(LanuchDetailsViewModel.FlightNumber) ||
                e.PropertyName == nameof(LanuchDetailsViewModel.LaunchDateUtc) ||
                e.PropertyName == nameof(LanuchDetailsViewModel.MissionName))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return
                !string.IsNullOrEmpty(lanuchDetailsViewModel.Details) &&
                !string.IsNullOrEmpty(lanuchDetailsViewModel.LaunchSuccess) &&
                !string.IsNullOrEmpty(lanuchDetailsViewModel.Upcoming) &&
                !string.IsNullOrEmpty(lanuchDetailsViewModel.FlightNumber) &&
                !string.IsNullOrEmpty(lanuchDetailsViewModel.LaunchDateUtc) &&
                !string.IsNullOrEmpty(lanuchDetailsViewModel.MissionName) &&
                base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object parameter)
        {
            // todo consider to change it by guid id
            Launch launch = new Launch(lanuchDetailsViewModel.Details, lanuchDetailsViewModel.FlightNumber, lanuchDetailsViewModel.LaunchDateUtc, lanuchDetailsViewModel.LaunchSuccess, lanuchDetailsViewModel.MissionName, lanuchDetailsViewModel.Upcoming);
            await company.UpdateLaunch(launch);
            navigationService.Navigate();
        }
    }
}

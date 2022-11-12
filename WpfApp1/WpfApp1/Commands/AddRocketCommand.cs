using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class AddRocketCommand : CommandBase
    {
        private readonly AddRocketViewModel _addRocketViewModel;
        private readonly Company _company;
        private readonly NavigationService _rocketListViewNavigationService;

        public AddRocketCommand(AddRocketViewModel addRocketViewModel, Company company, NavigationService rocketListViewNavigationService)
        {
            _addRocketViewModel = addRocketViewModel;
            _company = company;
            this._rocketListViewNavigationService = rocketListViewNavigationService;
            _addRocketViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        // TODO OG make here checks for other fields
        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_addRocketViewModel.Name) && base.CanExecute(parameter);
        }

        public override void Execute(object? parameter)
        {
            Rocket rocket = new Rocket(
                _addRocketViewModel.Name,
                "generate random id",
                new Engine(_addRocketViewModel.EngineNumber, _addRocketViewModel.EngineType));
            _company.AddRocket(rocket);
            _rocketListViewNavigationService.Navigate();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            // TODO OG add here || other property check
            if (e.PropertyName == nameof(AddRocketViewModel.Name))
            {
                OnCanExecuteChanged();
            }
        }
    }
}

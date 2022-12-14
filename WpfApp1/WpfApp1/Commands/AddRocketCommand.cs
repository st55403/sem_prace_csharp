using System.ComponentModel;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class AddRocketCommand : AsyncCommandBase
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
        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_addRocketViewModel.Name) && 
                !string.IsNullOrEmpty(_addRocketViewModel.EngineType) &&
                _addRocketViewModel.EngineNumber >= 1 &&
                base.CanExecute(parameter);
        }

        public override async Task ExecuteAsync(object? parameter)
        {
            // todo Og generate a random id
            Rocket rocket = new Rocket(
                _addRocketViewModel.Name,
                "generate random id",
                new Engine(_addRocketViewModel.EngineNumber, _addRocketViewModel.EngineType));
            await _company.AddRocket(rocket);
            _rocketListViewNavigationService.Navigate();
        }

        private void OnViewModelPropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(AddRocketViewModel.Name) || 
                e.PropertyName == nameof(AddRocketViewModel.EngineType) ||
                e.PropertyName == nameof(AddRocketViewModel.EngineNumber))
            {
                OnCanExecuteChanged();
            }
        }
    }
}

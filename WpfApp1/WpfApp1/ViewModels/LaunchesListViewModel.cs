using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.Stores;

namespace WpfApp1.ViewModels
{
    public class LaunchesListViewModel : ViewModelBase
    {
        private ObservableCollection<LaunchViewModel> _launches;

        private LaunchViewModel _selectedItem;
        public LaunchViewModel SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                OnPropertyChanged(nameof(SelectedItem));
            }
        }

        public ICollectionView LaunchesCollectionView { get; }
        private string _launchesFilter = string.Empty;
        public string LaunchesFilter
        {
            get
            {
                return _launchesFilter;
            }
            set
            {
                _launchesFilter = value;
                OnPropertyChanged(nameof(LaunchesFilter));
                LaunchesCollectionView.Refresh();
            }
        }

        public IEnumerable<LaunchViewModel> Launches => _launches;
        public ICommand LoadLaunchesCommand { get; }
        public ICommand AddLaunchCommand { get; }
        public ICommand DetailsLaunchCommand { get; }
        public ICommand BackCommand { get; }
        public LaunchesListViewModel(
            Company company, 
            NavigationService navigationServiceToAddLaunch, 
            NavigationService navigationServiceToCompanyInfo,
            NavigationService navigationServiceToLaunchDetails)
        {
            _launches = new ObservableCollection<LaunchViewModel>();
            LaunchesCollectionView = CollectionViewSource.GetDefaultView(_launches);

            LaunchesCollectionView.Filter = FilterLaunches;
            LoadLaunchesCommand = new LoadLaunchesCommand(this, company);
            AddLaunchCommand = new NavigateCommandToAddRocket(navigationServiceToAddLaunch);
            BackCommand = new NavigateCommandToCompanyInfo(navigationServiceToCompanyInfo);
            DetailsLaunchCommand = new NavigateCommandToLaunchDetails(navigationServiceToLaunchDetails);
        }

        private bool FilterLaunches(object obj)
        {
            if (obj is LaunchViewModel launchViewModel)
            {
                return launchViewModel.MissionName.Contains(LaunchesFilter, StringComparison.InvariantCultureIgnoreCase) ||
                    launchViewModel.LaunchSuccess.Contains(LaunchesFilter, StringComparison.CurrentCultureIgnoreCase);
            }

            return false;
        }

        public static LaunchesListViewModel LoadViewModel(
            Company company,
            NavigationService navigationServiceToAddLaunch,
            NavigationService navigationServiceToCompanyInfo,
            NavigationService navigationServiceToLaunchDetails)
        {
            LaunchesListViewModel viewModel = new LaunchesListViewModel(
                company, 
                navigationServiceToAddLaunch,
                navigationServiceToCompanyInfo,
                navigationServiceToLaunchDetails);
            viewModel.LoadLaunchesCommand.Execute(null);
            return viewModel;
        }

        public void UpdateLaunches(IEnumerable<Launch> launches)
        {
            _launches.Clear();
            foreach (Launch la in launches)
            {
                LaunchViewModel launchViewModel = new LaunchViewModel(la);
                _launches.Add(launchViewModel);
            }
        }
    }
}

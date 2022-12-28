using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.DbContexts;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.Services.API;
using WpfApp1.Services.LaunchCreators;
using WpfApp1.Services.LaunchProviders;
using WpfApp1.Services.RocketCreators;
using WpfApp1.Services.RocketProviders;
using WpfApp1.Services.ShipCreators;
using WpfApp1.Services.ShipProviders;
using WpfApp1.Stores;
using WpfApp1.ViewModels;
using WpfApp1.Views;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source=spacex.db";

        private readonly Company _company;
        private NavigationStore _navigationStore;
        private SpaceXDbContextFactory _spaceXDbContextFactory;

        public App()
        {
            _spaceXDbContextFactory = new SpaceXDbContextFactory(CONNECTION_STRING);
            IRocketProvider rocketProvider = new DatabaseRocketProvider(_spaceXDbContextFactory);
            IRocketCreator rocketCreator = new DatabaseRocketCreator(_spaceXDbContextFactory);
            RocketGarage rocketGarage = new RocketGarage(rocketProvider, rocketCreator);
            IShipProvider shipProvider = new DatabaseShipProvider(_spaceXDbContextFactory);
            IShipCreator shipCreator = new DatabaseShipCreator(_spaceXDbContextFactory);
            ShipPort shipPort = new ShipPort(shipProvider, shipCreator);
            ILaunchProvider launchProvider = new DatabaseLaunchProvider(_spaceXDbContextFactory);
            ILaunchCreator launchCreator = new DatabaseLaunchCreator(_spaceXDbContextFactory);
            LaunchRecords launchRecords = new LaunchRecords(launchProvider, launchCreator);
            _company = new Company("SpaceX", rocketGarage, shipPort, launchRecords);
            _navigationStore = new NavigationStore();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            SpaceXService apiService = new SpaceXService();
            var launches = await apiService.GetAllLaunches();

            using (SpaceXDbContext dbContext = _spaceXDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }
            //_navigationStore.CurrentViewModel = CreateRocketListViewModel();
            _navigationStore.CurrentViewModel = CreateCompanyInfoViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private CompanyInfoViewModel CreateCompanyInfoViewModel()
        {
            return new CompanyInfoViewModel(
                _company,
                new NavigationService(_navigationStore, CreateRocketListViewModel),
                new NavigationService(_navigationStore, CreateLaunchesListViewModel),
                new NavigationService(_navigationStore, CreateShipsListViewModel));
        }

        private LaunchesListViewModel CreateLaunchesListViewModel()
        {
            return LaunchesListViewModel.LoadViewModel(
                _company,
                new NavigationService(_navigationStore, CreateAddLaunchViewModel),
                new NavigationService(_navigationStore, CreateCompanyInfoViewModel),
                new NavigationService(_navigationStore, CreateLaunchDetailsViewModel));
        }

        private AddLaunchViewModel CreateAddLaunchViewModel()
        {
            return new AddLaunchViewModel(
                _company,
                new NavigationService(_navigationStore, CreateLaunchesListViewModel));
        }

        private LanuchDetailsViewModel CreateLaunchDetailsViewModel()
        {
            return new LanuchDetailsViewModel(
                _company,
                new NavigationService(_navigationStore, CreateLaunchesListViewModel));
        }

        private ShipsListViewModel CreateShipsListViewModel()
        {
            return ShipsListViewModel.LoadViewModel(
                _company,
                new NavigationService(_navigationStore, CreateAddShipViewModel),
                new NavigationService(_navigationStore, CreateCompanyInfoViewModel));
        }

        private AddShipViewModel CreateAddShipViewModel()
        {
            return new AddShipViewModel(
                _company,
                new NavigationService(_navigationStore, CreateShipsListViewModel));
        }

        private RocketListViewModel CreateRocketListViewModel()
        {
            return RocketListViewModel.LoadViewModel(
                _company, 
                new NavigationService(_navigationStore, CreateAddRocketViewModel),
                new NavigationService(_navigationStore, CreateCompanyInfoViewModel));
        }

        private AddRocketViewModel CreateAddRocketViewModel()
        {
            return new AddRocketViewModel(_company, new NavigationService(_navigationStore, CreateRocketListViewModel));
        }
    }
}

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
using WpfApp1.Services.RocketCreators;
using WpfApp1.Services.RocketProviders;
using WpfApp1.Stores;
using WpfApp1.ViewModels;

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
            _company = new Company("SpaceX", rocketGarage);
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            using (SpaceXDbContext dbContext = _spaceXDbContextFactory.CreateDbContext())
            {
                dbContext.Database.Migrate();
            }
            _navigationStore.CurrentViewModel = CreateRocketListViewModel();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private AddRocketViewModel CreateAddRocketViewModel()
        {
            return new AddRocketViewModel(_company, new NavigationService(_navigationStore, CreateRocketListViewModel));
        }

        private RocketListViewModel CreateRocketListViewModel()
        {
            return RocketListViewModel.LoadViewModel(_company, new NavigationService(_navigationStore, CreateAddRocketViewModel));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.Stores;
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly Company _company;
        private NavigationStore _navigationStore;

        public App()
        {
            _company = new Company("SpaceX");
            _navigationStore = new NavigationStore();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
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
            return new RocketListViewModel(_company, new NavigationService(_navigationStore, CreateAddRocketViewModel));
        }
    }
}

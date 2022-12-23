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
        private string details;
        public string Details
        {
            get
            {
                return details;
            }
            set
            {
                details = value;
                OnPropertyChanged(nameof(Details));
            }
        }

        private string flightNumber;
        public string FlightNumber
        {
            get
            {
                return flightNumber;
            }
            set
            {
                flightNumber = value;
                OnPropertyChanged(nameof(FlightNumber));
            }
        }

        private string launchDateUtc;
        public string LaunchDateUtc 
        {
            get
            {
                return launchDateUtc;
            }
            set
            {
                launchDateUtc = value;
                OnPropertyChanged(nameof(LaunchDateUtc));
            }
        }

        private string launchSuccess;
        public string LaunchSuccess
        {
            get
            {
                return launchSuccess;
            }
            set
            {
                launchSuccess = value;
                OnPropertyChanged(nameof(LaunchSuccess));
            }
        }

        private string missionName;
        public string MissionName
        {
            get
            {
                return missionName;
            }
            set
            {
                missionName = value;
                OnPropertyChanged(nameof(MissionName));
            }
        }

        private string upcoming;
        public string Upcoming
        {
            get
            {
                return upcoming;
            }
            set
            {
                upcoming = value;
                OnPropertyChanged(nameof(Upcoming));
            }
        }
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

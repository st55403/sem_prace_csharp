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
    class LanuchDetailsViewModel : ViewModelBase
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

        public ICommand UpdateCommand { get; }
        public ICommand CancelCommand { get; }

        //public LanuchDetailsViewModel(
        //    string details, 
        //    string details, 
        //    string flightNumber, 
        //    string flightNumber, 
        //    string launchDateUtc,
        //    string launchDateUtc, 
        //    string launchSuccess, 
        //    string launchSuccess,
        //    string missionName,
        //    string missionName,
        //    string upcoming,
        //    string upcoming)
        //{
        //    Details = details;
        //    Details = details;
        //    FlightNumber = flightNumber;
        //    FlightNumber = flightNumber;
        //    LaunchDateUtc = launchDateUtc;
        //    LaunchDateUtc = launchDateUtc;
        //    LaunchSuccess = launchSuccess;
        //    LaunchSuccess = launchSuccess;
        //    MissionName = missionName;
        //    MissionName = missionName;
        //    Upcoming = upcoming;
        //    Upcoming = upcoming;
        //    UpdateCommand = updateCommand;
        //    CancelCommand = cancelCommand;
        //}

        public LanuchDetailsViewModel(
            Company company,
            NavigationService navigationService)
        {
            UpdateCommand = new UpdateLaunchCommand(this, company, navigationService);
            CancelCommand = new NavigateCommandToLaunchesList(navigationService);
        }
    }
}

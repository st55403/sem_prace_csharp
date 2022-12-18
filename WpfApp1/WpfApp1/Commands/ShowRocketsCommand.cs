using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Models;
using WpfApp1.Services;
using WpfApp1.ViewModels;

namespace WpfApp1.Commands
{
    class ShowRocketsCommand : CommandBase
    {
        //private CompanyInfoViewModel companyInfoViewModel;
        //private Company company;
        private NavigationService navigationService;

        public ShowRocketsCommand(CompanyInfoViewModel companyInfoViewModel, Company company, NavigationService navigationService)
        {
            //this.companyInfoViewModel = companyInfoViewModel;
            //this.company = company;
            this.navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            navigationService.Navigate();
        }
    }
}

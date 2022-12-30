using WpfApp1.Models;

namespace WpfApp1.Commands
{
    class FetchAPIData : CommandBase
    {
        private Company company;
        public FetchAPIData(Company company)
        {
            this.company = company;
        }

        public override void Execute(object parameter)
        {
            company.FetchDataFromSpaceXServiceAndChachLocally();
        }
    }
}

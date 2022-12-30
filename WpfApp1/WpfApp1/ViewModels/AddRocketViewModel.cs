using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;
using WpfApp1.Services;

namespace WpfApp1.ViewModels
{
    class AddRocketViewModel : ViewModelBase
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        private int _engineNumber;
        public int EngineNumber
        {
            get
            {
                return _engineNumber;
            }
            set
            {
                _engineNumber = value;
                OnPropertyChanged(nameof(EngineNumber));
            }
        }

        private string _engineType;
        public string EngineType
        {
            get
            {
                return _engineType;
            }
            set
            {
                _engineType = value;
                OnPropertyChanged(nameof(EngineType));
            }
        }

        public ICommand AddCommand { get; }

        public ICommand CancelCommand { get; }

        public AddRocketViewModel(Company company, NavigationService addRocketViewNavigationService)
        {
            AddCommand = new AddRocketCommand(this, company, addRocketViewNavigationService);
            CancelCommand = new NavigateCommandToAddRocket(addRocketViewNavigationService);
        }
    }
}

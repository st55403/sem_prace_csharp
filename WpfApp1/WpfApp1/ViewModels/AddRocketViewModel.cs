using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfApp1.Commands;
using WpfApp1.Models;

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

        public AddRocketViewModel(Company company)
        {
            AddCommand = new AddRocketCommand(this, company);
            CancelCommand = new CancelAddRocketCommand();
        }
    }
}

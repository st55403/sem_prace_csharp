using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class RocketViewModel : ViewModelBase
    {
        private Rocket _rocket;

        public string RocketName => _rocket.RocketName;
        public string RocketID => _rocket.RocketID;
        public string EngineNumber => _rocket.engine.Number.ToString();
        public string EngineType => _rocket.engine.Type;

        public RocketViewModel(Rocket rocket)
        {
            _rocket = rocket;
        }
    }
}

namespace WpfApp1.Models
{
    public class Rocket
    {
        public string RocketName { get; set; }
        public string RocketID { get; set; }
        public Engine engine { get; set; }

        public Rocket(string rocketName, string rocketID, Engine engine)
        {
            RocketName = rocketName;
            RocketID = rocketID;
            this.engine = engine;
        }
    }

    public class Engine
    {
        public int Number { get; set; }
        public string Type { get; set; }

        public Engine(int number, string type)
        {
            Number = number;
            Type = type;
        }
    }
}

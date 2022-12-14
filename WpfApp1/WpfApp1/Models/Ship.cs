namespace WpfApp1.Models
{
    public class Ship
    {
        public string ShipId { get; set; }
        public string HomePort { get; set; }
        public string YearOfBuild { get; set; }

        public string Status { get; set; }

        public string Mission { get; set; }

        public Ship(string iD, string homePort, string yearOfBuild, string status, string mission)
        {
            ShipId = iD;
            HomePort = homePort;
            YearOfBuild = yearOfBuild;
            Status = status;
            Mission = mission;
        }
    }
}

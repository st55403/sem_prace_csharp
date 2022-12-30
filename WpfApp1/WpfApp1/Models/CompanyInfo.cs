using System;

namespace WpfApp1.Models
{
    public class CompanyInfo
    {
        public string Ceo { get; set; }
        public string Employees { get; set; }
        public string Founded { get; set; }
        public string Founder { get; set; }
        public string Summary { get; set; }

        public CompanyInfo(string ceo, string employees, string founded, string founder, string summary)
        {
            Ceo = ceo;
            Employees = employees;
            Founded = founded;
            Founder = founder;
            Summary = summary;
        }

        public override string? ToString()
        {
            return String.Format("The compsny has been founded by {0} in {1} number of employees is {2}. Summary: {3}",
                Founder, Founded, Employees, Summary);
        }

    }
}

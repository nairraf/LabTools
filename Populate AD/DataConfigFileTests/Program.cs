using Nett;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConfigFileTests
{
    class Program
    {
        public class Configuration
        {
            public Company Company { get; set; }
            public Dictionary<string, Dictionary<string, Locations>> Locations { get; set;}
            public Dictionary<string, Dictionary<string, OrgTop>> OrgTop { get; set; }
        }

        public class Company
        {
            public string Name { get; set; }
        }

        public class Locations
        {
            public string Name { get; set; }
            public string rContinent { get; set; }
            public string rCountry { get; set; }
            public string rPopulation { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
        }

        public class OrgTop
        {
            public string Department { get; set; }
            public string Title { get; set; }
            public string Location { get; set; }
            public string NumPeople { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            //var data = Toml.ReadFile("OrgChart.toml").ToDictionary();
            //var confCompany = (Dictionary<string, object>)data["Company"];
            //var confLocation = (Dictionary<string, object>)data["Locations"];
            //var confOrg = (Dictionary<string, object>)data["OrgTop"];

            var data = Toml.ReadFile<Configuration>("OrgChart.toml");

            Console.WriteLine("Company Name: " + data.Company.Name);

            Console.ReadLine();
        }
    }
}

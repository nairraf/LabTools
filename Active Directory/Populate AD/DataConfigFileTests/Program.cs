using Nett;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace DataConfigFileTests
{
    class Program
    {
        public class Settings
        {
            public string CompanyName { get; set; }
            public List<Location> Locations { get; set; }
            public List<Employee> Org { get; set; }
        }

        public class Location
        {
            public string Name { get; set; }
            public string RContinent { get; set; }
            public string RPopulation { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
        }

        public class Employee
        {
            public string Title { get; set; }
            public string Department { get; set; }
            public string Location { get; set; }
            public string NumPeople { get; set; }
            public List<Employee> Employees { get; set; }
        }

        static void Main(string[] args)
        {
            //YAML Desirialize to Object Example
            var deserializer = new DeserializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build();
            var settings = deserializer.Deserialize<Settings>(File.OpenText("Settings.yaml"));

            Console.WriteLine("The Second Location Name: {0}", settings.Locations[1].Name);
            Console.WriteLine("Company Name: {0}", settings.CompanyName);
            Console.WriteLine("Org:");
            PrintEmployees(settings.Org);

            Console.ReadLine();
        }

        public static void PrintEmployees(List<Employee> Employees, Employee Parent = null, int Level = 0)
        {
            foreach (Employee emp in Employees)
            {
                if (Parent != null)
                {
                    for (int i = 0; i < Level; i++)
                    {
                        Console.Write("    ");
                    }
                    Console.WriteLine("Title: {0}, Parent: {1}", emp.Title, Parent.Title);
                } else
                {
                    Console.WriteLine("Title: {0}", emp.Title);
                }
                
                if (emp.Employees != null && emp.Employees.Any())
                {
                    Level += 1;
                    PrintEmployees(emp.Employees, emp, Level);
                }
            }
        }

    }
}

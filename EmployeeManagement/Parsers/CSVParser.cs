using EmployeeManagement.Enums;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using System.Xml.Linq;


namespace EmployeeManagement.Parsers
{
    public class CSVParser
    {
        public static Rank GetRank(string rank)
        {
            switch (rank)
            {
                case "Junior":
                    return Rank.Junior;
                case "Middle":
                    return Rank.Middle;
                case "Senior":
                    return Rank.Senior;
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        public static string GetRankAsString(Rank rank)
        {
            switch (rank)
            {
                case Rank.Junior:
                    return "Junior";
                case Rank.Middle:
                    return "Middle";
                case Rank.Senior:
                    return "Senior";
                default:
                    throw new InvalidEnumArgumentException();
            }
        }

        private static string GetAllLanguages(string languages)
        {
            List<Languages> list = new List<Languages>();

            foreach (var language in languages.Split(','))
            {
                switch (language)
                {
                    case "C":
                        list.Add(Languages.C);
                        break;
                    case "C++":
                        list.Add(Languages.C_Plus_Plus);
                        break;
                    case "C#":
                        list.Add(Languages.C_Sharp);
                        break;
                    case "JS":
                        list.Add(Languages.JS);
                        break;
                    case "Python":
                        list.Add(Languages.Python);
                        break;
                    case "PHP":
                        list.Add(Languages.PHP);
                        break;
                    case "Java":
                        list.Add(Languages.Java);
                        break;
                }
            }

            return languages;
        }

        public static string EmployeeToCSVLine(Employee employee)
        {
            string rank = GetRankAsString(employee.Rank);
            return employee.Name + ';' + employee.CreatedAt + ';' + rank + ";" + employee.Languages;
        }

        public static Employee Parse(string line)
        {
            string[] parts = line.Split(';');

            return new Employee()
            {
                Name = parts[0],
                CreatedAt = DateTime.Parse(parts[1]),
                Rank = GetRank(parts[2]),
                Languages = GetAllLanguages(parts[3])
            };
        }

        // public override string ToString()
        // {
            // return $"{Name} -> {Description} -> {TaskFinishedDateTime} -> {Rank}";
        // }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Enums;
using EmployeeManagement.Models;
using EmployeeManagement.Parsers;

namespace EmployeeManagement.Services
{
    internal class EmployeeService : IEmployeeService
    {

        private string[] readEmployeeFile()
        {
            IEnumerable<string> employees = File.ReadAllLines(Settings.EmployeeFilePath).Skip(1);
            return employees.ToArray();
        }

        public List<Employee> GetAll()
        {
            List<Employee> list = new List<Employee>();
            IEnumerable<string> employees = File.ReadAllLines(Settings.EmployeeFilePath).Skip(1);
            foreach (string employee in employees)
                list.Add(CSVParser.Parse(employee));

            return list;
        }

        public Employee GetOne(string name, DateTime? CreatedAt = null)
        {
            List<Employee> employees = GetAll()
                .Where(e => e.Name == name)
                .ToList();
            if (CreatedAt != null)
                employees = employees.Where(e => e.CreatedAt == CreatedAt).ToList();

            return employees.FirstOrDefault();
        }

        public Employee GetOne(DateTime CreatedAt)
        {
            List<Employee> employees = GetAll()
                .Where(e => e.CreatedAt == CreatedAt)
                .ToList();

            return employees.FirstOrDefault();
        }

        public List<Employee> FilterByRank(Rank rank)
        {
            return GetAll()
                .Where(e => e.Rank == rank)
                .ToList();
        }

        public bool AddEmployee(Employee employee)
        {
            string csvLineEmployee = CSVParser.EmployeeToCSVLine(employee);

            try
            {
                using StreamWriter sw = File.AppendText(Settings.EmployeeFilePath);
                sw.WriteLine(csvLineEmployee);
            }
            catch (Exception)
            {
                return false;
            }

            return true;
        }

        public bool UpdateEmployee(Employee employee)
        {
            string csvLineEmployee = CSVParser.EmployeeToCSVLine(employee);
            string[] employeeFileLines = readEmployeeFile();

            for (int i = 0; i < employeeFileLines.Length; i++)
            {
                DateTime currentEmployeeDate = DateTime.Parse(employeeFileLines[i].Split(';')[1]);
                if (currentEmployeeDate == employee.CreatedAt)
                {
                    employeeFileLines[i] = csvLineEmployee;
                    break;
                }
            }
            
            string[] headers = { "name;date;rank;languages" };
            string[] finalData = headers.Concat(employeeFileLines).ToArray();

            File.WriteAllText(Settings.EmployeeFilePath, string.Empty);
            File.AppendAllLines(Settings.EmployeeFilePath, finalData);

            return true;
        }

        public bool DeleteEmployee(Employee employee)
        {
            string csvLineEmployee = CSVParser.EmployeeToCSVLine(employee);
            string[] employeeFileLines = readEmployeeFile();

            for (int i = 0; i < employeeFileLines.Length; i++)
            {
                DateTime currentEmployeeDate = DateTime.Parse(employeeFileLines[i].Split(';')[1]);
                if (currentEmployeeDate == employee.CreatedAt)
                {
                    // remove
                    int index = Array.IndexOf(employeeFileLines, employeeFileLines[i]);
                    if (index != -1)
                        employeeFileLines = employeeFileLines.Where((val, idx) => idx != index).ToArray();
                    break;
                }
            }

            string[] headers = { "name;date;rank;languages" };
            string[] finalData = headers.Concat(employeeFileLines).ToArray();

            File.WriteAllText(Settings.EmployeeFilePath, string.Empty);
            File.AppendAllLines(Settings.EmployeeFilePath, finalData);

            return true;
        }
    }
}

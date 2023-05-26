using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Enums;
using EmployeeManagement.Parsers;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public Rank Rank { get; set; }
        public string Languages { get; set; }
    }
}

using EmployeeManagement.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Models;
using EmployeeManagement.Parsers;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    public partial class AddEmployee : Form
    {
        private readonly IEmployeeService _employeeService;

        public AddEmployee()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            string[] rankNames = Enum.GetNames(typeof(Rank));
            string[] languagesNames = Enum.GetNames(typeof(Languages));

            foreach (string rankName in rankNames)
                rankComboBox.Items.Add(rankName);

            foreach (string languageName in languagesNames)
                languagesCheckedListBox.Items.Add(languageName.Replace("_", "")
                                                              .Replace("Plus", "+")
                                                              .Replace("Sharp", "#"));
        }

        private void AddEmployeeToCSV_Click(object sender, EventArgs e)
        {
            if (ValidateFormData())
            {
                string name = nameTextBox.Text;
                string rank = rankComboBox.Text;

                List<string> selectedProgrammingLanguages = new List<string>();

                foreach(object itemChecked in languagesCheckedListBox.CheckedItems)
                    selectedProgrammingLanguages.Add(itemChecked.ToString());

                bool addingResult = _employeeService.AddEmployee(new Employee()
                {
                    Name = name,
                    Rank = CSVParser.GetRank(rank),
                    CreatedAt = DateTime.Now,
                    Languages = string.Join(",", selectedProgrammingLanguages)
                });

                if(addingResult)
                    MessageBox.Show($"{name} has been added as {rank} developer!");
                else
                    MessageBox.Show($"Something went wrong");
            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private bool ValidateFormData()
        {
            // validate
            return true;
        }
    }
}

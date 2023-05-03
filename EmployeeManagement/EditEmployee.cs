using EmployeeManagement.Enums;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagement.Parsers;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    public partial class EditEmployee : Form
    {
        private readonly IEmployeeService _employeeService;
        public Employee EmployeeToEdit;
        public EditEmployee()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
        }

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            string[] rankNames = Enum.GetNames(typeof(Rank));
            string[] languagesNames = Enum.GetNames(typeof(Languages));
            string[] knownLanguagesNames = EmployeeToEdit.Languages.Split(',');

            foreach (string rankName in rankNames)
                rankComboBox.Items.Add(rankName);
            

            foreach (string languageName in languagesNames)
                languagesCheckedListBox.Items.Add(languageName);

            // rename languages
            for (int i = 0; i < languagesCheckedListBox.Items.Count; i++)
                languagesCheckedListBox.Items[i] = languagesCheckedListBox.Items[i].ToString().Replace("_", "")
                                                                                            .Replace("Plus", "+")
                                                                                            .Replace("Sharp", "#");
            foreach (string knownLanguageName in knownLanguagesNames)
            {
                int itemIndex = languagesCheckedListBox.FindStringExact(knownLanguageName);
                languagesCheckedListBox.SetItemChecked(itemIndex, true);
            }

            nameTextBox.Text = EmployeeToEdit.Name;
            rankComboBox.SelectedIndex = (int)EmployeeToEdit.Rank;
        }

        private void EditEmployeeToCSV_Click(object sender, EventArgs e)
        {
            List<string> selectedProgrammingLanguages = new List<string>();

            foreach (object itemChecked in languagesCheckedListBox.CheckedItems)
                selectedProgrammingLanguages.Add(itemChecked.ToString());

            bool updateResult = _employeeService.UpdateEmployee(new Employee()
            {
                Name = nameTextBox.Text,
                Rank = CSVParser.GetRank(rankComboBox.Text),
                CreatedAt = EmployeeToEdit.CreatedAt,
                Languages = string.Join(",", selectedProgrammingLanguages)
            });

            if (updateResult)
                MessageBox.Show("Update complete!");
            else
                MessageBox.Show("Something went wrong!");
        }
    }
}
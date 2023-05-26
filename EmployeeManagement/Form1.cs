using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using EmployeeManagement.Enums;
using EmployeeManagement.Models;
using EmployeeManagement.Parsers;
using EmployeeManagement.Services;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IPrinterService _printerService;
        
        public Form1()
        {
            InitializeComponent();
            _employeeService = new EmployeeService();
            _printerService = new PrinterService(printDialog);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] rankNames = Enum.GetNames(typeof(Rank));
            employeeRank.Items.Add(Settings.AllEmployeesText);
            foreach (string rankName in rankNames)
                employeeRank.Items.Add(rankName);

            IEnumerable<string> employeeLines = File.ReadAllLines(Settings.EmployeeFilePath).Skip(1);
            List<Employee> employees = new List<Employee>();

            foreach (string line in employeeLines)
                employees.Add(CSVParser.Parse(line));

            mainDataGridView.DataSource = employees;
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NarekPVP");
        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployeeForm = new AddEmployee();
            addEmployeeForm.ShowDialog();
        }

        private void employeeRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = employeeRank.GetItemText(employeeRank.SelectedItem);
            
            if(selected == Settings.AllEmployeesText)
            {
                List<Employee> employees = _employeeService.GetAll();
                mainDataGridView.DataSource = employees;
            }
            else
            {
                Rank rank = CSVParser.GetRank(selected);
                List<Employee> employees = _employeeService.FilterByRank(rank);
                
                mainDataGridView.DataSource = employees;
            }
        }

        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            if(mainDataGridView.SelectedRows.Count > 0)
            {
                Employee selected = mainDataGridView.SelectedRows[0].DataBoundItem as Employee;

                EditEmployee editEmployeeForm = new EditEmployee();
                editEmployeeForm.EmployeeToEdit = selected;
                editEmployeeForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Select employee!");
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<string> employeeLines = File.ReadAllLines(Settings.EmployeeFilePath).Skip(1);
            List<Employee> employees = new List<Employee>();

            foreach (string line in employeeLines)
                employees.Add(CSVParser.Parse(line));

            mainDataGridView.DataSource = employees;
        }

        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            if (mainDataGridView.SelectedRows.Count > 0)
            {
                Employee selected = mainDataGridView.SelectedRows[0].DataBoundItem as Employee;
                bool deleteResult = _employeeService.DeleteEmployee(selected);

                if (deleteResult)
                    MessageBox.Show($"Employee {selected.Name} has been deleted");
                else
                    MessageBox.Show("Something went wrong!");
            }
            else
            {
                MessageBox.Show("Select employee!");
            }
        }

        private void exportAsCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true})
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = saveFileDialog.FileName;
                    File.Copy(Settings.EmployeeFilePath, selectedFilePath);
                    MessageBox.Show("File has been exported!");
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _printerService.InitializePrinter();
        
            try
            {
                bool printedSuccessfully = _printerService.PrintResult();

                if (printedSuccessfully)
                    MessageBox.Show("Printed");
                else
                    MessageBox.Show("Something went wrong!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

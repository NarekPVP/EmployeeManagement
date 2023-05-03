using EmployeeManagement.Enums;
using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    internal interface IEmployeeService
    {
        /// <summary>
        /// Returns a list of all employees.
        /// </summary>
        /// <returns>A list of all employees.</returns>
        List<Employee> GetAll();

        /// <summary>
        /// Returns a single employee with the specified name and creation date.
        /// </summary>
        /// <param name="name">The name of the employee to retrieve.</param>
        /// <param name="CreatedAt">The creation date of the employee to retrieve. If null, the most recent employee with the specified name will be returned.</param>
        /// <returns>The employee with the specified name and creation date, or null if no such employee exists.</returns>
        Employee GetOne(string name, DateTime? CreatedAt = null);

        /// <summary>
        /// Returns the employee with the specified creation date.
        /// </summary>
        /// <param name="CreatedAt">The creation date of the employee to retrieve.</param>
        /// <returns>The employee with the specified creation date, or null if no such employee exists.</returns>
        Employee GetOne(DateTime CreatedAt);

        /// <summary>
        /// Returns a list of employees with the specified rank.
        /// </summary>
        /// <param name="rank">The rank to filter by.</param>
        /// <returns>A list of employees with the specified rank.</returns>
        List<Employee> FilterByRank(Rank rank);

        /// <summary>
        /// Adds a new Employee to the system.
        /// </summary>
        /// <param name="employee">The Employee object to add to the system.</param>
        /// <returns>True if the Employee was successfully added, false otherwise.</returns>
        public bool AddEmployee(Employee employee);

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee to update.</param>
        /// <returns>true if the update was successful, false otherwise.</returns>
        bool UpdateEmployee(Employee employee);

        /// <summary>
        /// Deletes an existing Employee from the system.
        /// </summary>
        /// <param name="employee">The Employee object to delete from the system.</param>
        /// <returns>True if the Employee was successfully deleted, false otherwise.</returns>
        public bool DeleteEmployee(Employee employee);
    }

}

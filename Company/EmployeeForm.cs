using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyView
{
    public partial class EmployeeForm : Form
    {
        private DepartmentDomain _department;
        private EmployeeDomain _employeeToUpdate;
        public EmployeeForm(DepartmentDomain department)
        {
            _department = department;
            InitializeComponent();
        }
        public EmployeeForm(EmployeeDomain employee)
        {
            _employeeToUpdate = employee;
            InitializeComponent();

            SetEmployeeDataToInputFields(_employeeToUpdate);
        }

        private void addOrUpdateDepartmentButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            int salary = (int)salaryNumericUpDown.Value;

            // Add new employee to department
            if (_employeeToUpdate == null)
            {
                var employee = new EmployeeDomain(fullName, salary);
                _department.AddEmployee(employee);
            } // Update employee's data
            else
            {
                _employeeToUpdate.FullName = fullName;
                _employeeToUpdate.Salary = salary;
            }

            Close();
        }
        private void SetEmployeeDataToInputFields(EmployeeDomain employee)
        {
            fullNameTextBox.Text = employee.FullName;
            salaryNumericUpDown.Value = employee.Salary;
        }
    }
}

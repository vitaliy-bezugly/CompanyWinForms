using CompanyView;
using Controllers;
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

namespace Company;

public partial class CompanyForm : Form
{
    private DepartmentController _departmentController;
    public CompanyForm()
    {
        InitializeComponent();
    }
    private void CompanyForm_Load(object sender, EventArgs e)
    {
        _departmentController = new DepartmentController();
    }

    private void loadDataButton_Click(object sender, EventArgs e)
    {
        _departmentController.LoadData();
        var departments = _departmentController.GetDepartments().ToList();
        UpdateDepartmentDataSource(departments);
    }

    private void addDepartmentButton_Click(object sender, EventArgs e)
    {
        string departmentTitle = departmentTitleTextBox.Text;
        _departmentController.AddDepartment(new DepartmentDomain(departmentTitle));

        var departments = _departmentController.GetDepartments().ToList();
        UpdateDepartmentDataSource(departments);
    }
    private void updateDepartmentButton_Click(object sender, EventArgs e)
    {
        try
        {
            var department = GetSelectedDepartment();
            if (department == null)
                return;

            department.Title = departmentTitleTextBox.Text;

            var departments = _departmentController.GetDepartments().ToList();
            UpdateDepartmentDataSource(departments);
        }
        catch (Exception exception)
        {
            HandleException(exception);
        }
    }
    private void cellContent_Click(object sender, DataGridViewCellEventArgs e)
    {
        try
        {
            var department = GetSelectedDepartment();
            if (department == null)
                return;

            departmentTitleTextBox.Text = department.Title;

            /* Load department's employee */
            GetEmployeesAndUpdateDataSource(department);
        }
        catch (Exception exception)
        {
            HandleException(exception);
        }
    }

    private void addEmployeeButton_Click(object sender, EventArgs e)
    {
        try
        {
            var department = GetSelectedDepartment();
            if (department == null)
                return;

            var employeeForm = new EmployeeForm(department);
            employeeForm.ShowDialog();

            GetEmployeesAndUpdateDataSource(department);
        }
        catch (Exception exception)
        {
            HandleException(exception);
        }
    }
    private void updateEmployeeButton_Click(object sender, EventArgs e)
    {
        try
        {
            var employeeToUpdate = GetSelectedEmployee();
            if (employeeToUpdate == null)
                return;

            var form = new EmployeeForm(employeeToUpdate);
            form.ShowDialog();

            var department = GetSelectedDepartment();
            if (department == null)
                return;

            GetEmployeesAndUpdateDataSource(department);
        }
        catch (Exception exception)
        {
            HandleException(exception);
        }
    }

    private DepartmentDomain? GetSelectedDepartment()
    {
        if (departmentDataGridView.SelectedRows.Count == 0)
            return null;

        return departmentDataGridView.SelectedRows[0].DataBoundItem as DepartmentDomain;
    }
    private EmployeeDomain? GetSelectedEmployee()
    {
        if (employeeDataGridView.SelectedRows.Count == 0)
            return null;

        return employeeDataGridView.SelectedRows[0].DataBoundItem as EmployeeDomain;
    }

    private void HandleException(Exception exception)
    {
        MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void fullNameSortButton_Click(object sender, EventArgs e)
    {
        try
        {
            var selectedDepartment = GetSelectedDepartment();
            if (selectedDepartment == null)
                return;

            var employees = selectedDepartment.GetEmployees().OrderBy(x => x.FullName).ToList();
            UpdateEmployeeDataSource(employees);
        }
        catch (Exception exception)
        {
            HandleException(exception);
        }
    }

    private void UpdateDepartmentDataSource(List<DepartmentDomain> departments)
    {
        departmentDataGridView.DataSource = departments;
        departmentDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        departmentDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }
    private void UpdateEmployeeDataSource(List<EmployeeDomain> employees)
    {
        employeeDataGridView.DataSource = employees;

        employeeDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        employeeDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        employeeDataGridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
    }

    private void GetEmployeesAndUpdateDataSource(DepartmentDomain? department)
    {
        var result = _departmentController.GetEmployeeByDepartment(department.Id);

        result.Match<bool>(data =>
        {
            UpdateEmployeeDataSource(data.ToList());
            return true;
        }, exception =>
        {
            HandleException(exception);
            return false;
        });
    }
}
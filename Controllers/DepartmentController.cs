using Domain;
using LanguageExt.Common;
using Mappers;
using Repositories;
using Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers;

public class DepartmentController
{
    private List<DepartmentDomain> _departments;
    private IDepartmentRepository _departmentRepository;
    public DepartmentController()
    {
        _departments = new List<DepartmentDomain>();
        _departmentRepository = new DepartmentPersistenceRepository();
    }

    public IEnumerable<DepartmentDomain> GetDepartments()
    {
        foreach (var item in _departments)
        {
            yield return item;
        }
    }
    public Result<bool> AddDepartment(DepartmentDomain department)
    {
        if(_departments.Any(x => x.Id == department.Id))
            return new Result<bool>(new ArgumentException("The collection already has a department with the same id"));

        _departments.Add(department);
        return new Result<bool>(true);
    }
    public Result<bool> RemoveDepartment(string id)
    {
        var departmentToDelete = _departments.FirstOrDefault(x => x.Id == id);

        if (departmentToDelete == null)
            return new Result<bool>(new ArgumentException($"The collection does not have element with id: {id}"));

        _departments.Remove(departmentToDelete);
        return new Result<bool>(true);
    }
    public Result<bool> RemoveEmployeeFromDepartment(string departmentId, EmployeeDomain employee)
    {
        var department = _departments.FirstOrDefault(x => x.Id == departmentId);

        if (department == null)
            return new Result<bool>(new ArgumentException($"The collection does not have element with id: {departmentId}"));

        var result = department.RemoveEmployee(employee);
        if(result == false)
            return new Result<bool>(new ArgumentException($"Can not find employee with index: {employee.Id}"));
        
        return new Result<bool>(true);
    }
    public Result<IEnumerable<EmployeeDomain>> GetEmployeeByDepartment(string departmentId)
    {
        var department = _departments.FirstOrDefault(x => x.Id == departmentId);

        if (department == null)
            return new Result<IEnumerable<EmployeeDomain>>(new ArgumentException($"The collection does not have element with id: {departmentId}"));

        return new Result<IEnumerable<EmployeeDomain>>(department.GetEmployees());
    }

    public int LoadData()
    {
        _departments = _departmentRepository.GetAll().Select(x => x.ToDomain()).ToList();
        return _departments.Count;
    }
    public void SaveData()
    {
        _departmentRepository.SaveAll(_departments.Select(x => x.ToEntity()).ToList());
    }
}

using Domain;
using Entities;

namespace Mappers;

public static class EmployeeMapper
{
    public static EmployeeDomain ToDomain(this EmployeeEntity employee)
    {
        return new EmployeeDomain(employee.id, employee.fullName, employee.salary);
    }
    public static EmployeeEntity ToEntity(this EmployeeDomain employee)
    {
        return new EmployeeEntity
        {
            id = employee.Id,
            fullName = employee.FullName,
            salary = employee.Salary
        };
    }
}
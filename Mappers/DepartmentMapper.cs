using Domain;
using Entities;

namespace Mappers;

public static class DepartmentMapper
{
    public static DepartmentDomain ToDomain(this DepartmentEntity department)
    {
        return new DepartmentDomain(department.id, department.title,
            department.employees.Select(x => x.ToDomain()).ToList());
    }
    public static DepartmentEntity ToEntity(this DepartmentDomain department)
    {
        return new DepartmentEntity
        {
            id = department.Id,
            title = department.Title,
            employees = department.GetEmployees().Select(x => x.ToEntity()).ToList()
        };
    }
}
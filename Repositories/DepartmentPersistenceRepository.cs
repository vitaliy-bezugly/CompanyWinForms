using Entities;
using Microsoft.EntityFrameworkCore;
using Repositories.Abstract;
using Repositories.Persistence;

namespace Repositories;

public class DepartmentPersistenceRepository : IDepartmentRepository
{
    private readonly ApplicationDatabaseContext _dataContext;
    public DepartmentPersistenceRepository()
    {
        _dataContext = new ApplicationDatabaseContext();
    }

    public List<DepartmentEntity> GetAll()
    {
        return _dataContext.Departments.Include(x => x.employees).AsNoTracking().ToList();
    }
    public void SaveAll(List<DepartmentEntity> departments)
    {
        DeleteIfExist(departments);

        foreach (var item in departments)
        {
            Add(item);
        }

        _dataContext.SaveChanges();
    }

    private void Add(DepartmentEntity department)
    {
        _dataContext.Departments.Add(department);
    }
    private void DeleteIfExist(List<DepartmentEntity> departmentsToDelete)
    {
        foreach (var item in departmentsToDelete)
        {
            var exists = _dataContext.Departments.FirstOrDefault(x => x.id == item.id);
            if(exists != null)
            {
                _dataContext.Remove(exists);
            }
        }
        // _dataContext.SaveChanges();
    }
}

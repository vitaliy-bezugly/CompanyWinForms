using Entities;

namespace Repositories.Abstract;

public interface IDepartmentRepository
{
    public List<DepartmentEntity> GetAll();
    public void SaveAll(List<DepartmentEntity> departments);
}
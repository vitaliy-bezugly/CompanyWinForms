using Entities;
using Repositories.Abstract;
using System.Text.Json;

namespace Repositories;

public class DepartmentJsonRepository : IDepartmentRepository
{
    private const string filePath = "data/departments.json";

    public List<DepartmentEntity> GetAll()
    {
        using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            var departments = JsonSerializer.Deserialize<List<DepartmentEntity>>(stream);

            if(departments == null)
                return new List<DepartmentEntity>();

            return departments;
        }
    }
    public void SaveAll(List<DepartmentEntity> departments)
    {
        using (FileStream stream = new FileStream(filePath, FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize<List<DepartmentEntity>>(stream, departments);
        }
    }
}

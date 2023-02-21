namespace Entities;

public class DepartmentEntity
{
    public string id { get; set; }
    public string title { get; set; }
    public List<EmployeeEntity> employees { get; set; }
}

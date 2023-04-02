using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("Department")]
public class DepartmentEntity
{
    public string id { get; set; }
    public string title { get; set; }
    public ICollection<EmployeeEntity> employees { get; set; }
}

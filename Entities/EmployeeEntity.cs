using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

[Table("Employee")]
public class EmployeeEntity
{
    public string id { get; set; }
    public string fullName { get; set; }
    public int salary { get; set; }
    [ForeignKey(nameof(DepartmentEntity))]
    public string departmentId { get; set; }
    public DepartmentEntity? department { get; set; }
}
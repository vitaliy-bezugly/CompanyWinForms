using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain;

public class EmployeeDomain
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FullName { get; set; }
    public int Salary { get; set; }
    public EmployeeDomain()
    {
        FullName = string.Empty;
        Salary = 0;
    }
    public EmployeeDomain(string fullName, int salary)
    {
        Id = Guid.NewGuid().ToString();
        FullName = fullName;
        Salary = salary;
    }
}

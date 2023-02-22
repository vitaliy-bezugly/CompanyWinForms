namespace Domain;

public class DepartmentDomain
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string Title { get; set; }
    private List<EmployeeDomain> _employees;

    public DepartmentDomain()
    {
        Title = string.Empty;
        _employees = new List<EmployeeDomain>();
    }
    public DepartmentDomain(string title)
    {
        Title = title;
        _employees = new List<EmployeeDomain>();
    }
    public DepartmentDomain(string title, List<EmployeeDomain> employees)
    {
        Title = title;
        _employees = employees;
    }
    public DepartmentDomain(string id, string title, List<EmployeeDomain> employees)
    {
        Id = id;
        Title = title;
        _employees = employees;
    }

    public IEnumerable<EmployeeDomain> GetEmployees()
    {
        foreach (var item in _employees)
        {
            yield return item;
        }
    }
    public void AddEmployee(EmployeeDomain employee)
    {
        _employees.Add(employee);
    }
}

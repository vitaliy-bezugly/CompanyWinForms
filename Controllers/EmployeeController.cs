using Domain;
using LanguageExt.Common;

namespace Controllers;

public class EmployeeController
{
    private List<EmployeeDomain> _employees;

    public EmployeeController()
    {
        _employees = new List<EmployeeDomain>();
    }

    public IEnumerable<EmployeeDomain> GetEmployees()
    {
        foreach (var item in _employees)
        {
            yield return item;
        }
    }

    public Result<bool> LoadData()
    {
        if (_employees.Count > 0)
            return new Result<bool>(true);

        return new Result<bool>(new Exception("Can not get data from persistance data source"));
    }
    public void SaveData()
    {
        throw new NotImplementedException();
    }
}

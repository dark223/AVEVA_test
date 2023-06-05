using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Repos.Employees
{
    public interface IEmployeeRopo
    {
        IEnumerable<Employee> Get();

        IEnumerable<Employee> Get(string field,string value);

        string Update(Employee employee);

        string Create(EmployeeDTO employee);
    }
}

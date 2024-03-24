using EmployeeCrudApi.Employees.Dto;
using EmployeeCrudApi.Employees.Model;

namespace EmployeeCrudApi.Employees.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> GetAllAsync();
        //Task<Product> GetByNameAsync(string name);
        //Task<Product> GetByIdAsync(int id);
        //Task<Product> CreateAsync(CreateProductRequest productRequest);
        //Task<Product> UpdateAsync(int id, UpdateProductRequest productRequest);
        //Task DeleteAsync(int id);
    }
}

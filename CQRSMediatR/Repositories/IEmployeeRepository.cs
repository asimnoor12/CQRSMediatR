using CQRSMediatR.Models;

namespace CQRSMediatR.Repositories
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllEmployeeAsync();
        Task<Employee?> GetEmployeeByIdAsync(int Id);
        Task<Employee> AddEmployeeAsync(Employee employee);
        Task<int> UpdateEmployeeAsync(Employee employee);
        Task<int> DeleteEmployeeAsync(int Id);
    }
}

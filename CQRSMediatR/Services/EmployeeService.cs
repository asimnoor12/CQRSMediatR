using CQRSMediatR.Data;
using CQRSMediatR.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSMediatR.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            var result = await _context.Employees.ToListAsync();
            return result;
        }

        public async Task<Employee?> GetEmployeeByIdAsync(int Id)
        {
            return await _context.Employees.FindAsync(Id);
        }

        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result = _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteEmployeeAsync(int Id)
        {
            var employee = await _context.Employees.FindAsync(Id);
            _context.Employees.Remove(employee);
            return await _context.SaveChangesAsync();  
        }
    }
}

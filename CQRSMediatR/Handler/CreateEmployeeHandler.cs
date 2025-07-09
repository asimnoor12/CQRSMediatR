using CQRSMediatR.Command;
using CQRSMediatR.Models;
using CQRSMediatR.Repositories;
using MediatR;

namespace CQRSMediatR.Handler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public CreateEmployeeHandler(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<Employee> Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = new Employee
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone
            };

            return await _employeeRepo.AddEmployeeAsync(employee);
        }
    }
}

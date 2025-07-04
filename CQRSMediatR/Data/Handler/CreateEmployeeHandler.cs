using CQRSMediatR.Data.Command;
using CQRSMediatR.Models;
using CQRSMediatR.Services;
using MediatR;

namespace CQRSMediatR.Data.Handler
{
    public class CreateEmployeeHandler : IRequestHandler<CreateEmployeeCommand, Employee>
    {
        private readonly IEmployeeService _employeeService;

        public CreateEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
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

            return await _employeeService.AddEmployeeAsync(employee);
        }
    }
}

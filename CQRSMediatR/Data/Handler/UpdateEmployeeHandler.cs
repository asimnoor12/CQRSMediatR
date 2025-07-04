using CQRSMediatR.Data.Command;
using CQRSMediatR.Models;
using CQRSMediatR.Services;
using MediatR;

namespace CQRSMediatR.Data.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeService _employeeService;

        public UpdateEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            employee.Name = request.Name;
            employee.Address = request.Address;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
         
            return await _employeeService.UpdateEmployeeAsync(employee);
        }
    }
}

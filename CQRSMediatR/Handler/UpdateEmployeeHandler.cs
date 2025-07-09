using CQRSMediatR.Command;
using CQRSMediatR.Models;
using CQRSMediatR.Repositories;
using MediatR;

namespace CQRSMediatR.Handler
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public UpdateEmployeeHandler(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepo.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            employee.Name = request.Name;
            employee.Address = request.Address;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
         
            return await _employeeRepo.UpdateEmployeeAsync(employee);
        }
    }
}

using CQRSMediatR.Data.Command;
using CQRSMediatR.Services;
using MediatR;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace CQRSMediatR.Data.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeService _employeeService;

        public DeleteEmployeeHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeService.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            return await _employeeService.DeleteEmployeeAsync(request.Id);
        }
    }
}

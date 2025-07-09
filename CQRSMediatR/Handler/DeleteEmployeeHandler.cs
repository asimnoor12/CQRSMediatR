using CQRSMediatR.Command;
using CQRSMediatR.Repositories;
using MediatR;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace CQRSMediatR.Handler
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public DeleteEmployeeHandler(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee = await _employeeRepo.GetEmployeeByIdAsync(request.Id);
            if (employee == null) return default;

            return await _employeeRepo.DeleteEmployeeAsync(request.Id);
        }
    }
}

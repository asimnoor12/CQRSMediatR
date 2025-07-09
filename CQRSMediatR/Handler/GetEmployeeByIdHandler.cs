using CQRSMediatR.Models;
using CQRSMediatR.Query;
using CQRSMediatR.Repositories;
using MediatR;

namespace CQRSMediatR.Handler
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee?>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetEmployeeByIdHandler(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<Employee?> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetEmployeeByIdAsync(request.Id);
        }
    }
}

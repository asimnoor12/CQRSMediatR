using CQRSMediatR.Models;
using CQRSMediatR.Query;
using CQRSMediatR.Repositories;
using MediatR;

namespace CQRSMediatR.Handler
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeRepository _employeeRepo;

        public GetAllEmployeesHandler(IEmployeeRepository employeeRepo)
        {
            _employeeRepo = employeeRepo;
        }

        public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _employeeRepo.GetAllEmployeeAsync();
        }
    }
}

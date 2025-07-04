using CQRSMediatR.Data.Query;
using CQRSMediatR.Models;
using CQRSMediatR.Services;
using MediatR;

namespace CQRSMediatR.Data.Handler
{
    public class GetAllEmployeesHandler : IRequestHandler<GetAllEmployeesQuery, List<Employee>>
    {
        private readonly IEmployeeService _employeeService;

        public GetAllEmployeesHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<List<Employee>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetAllEmployeeAsync();
        }
    }
}

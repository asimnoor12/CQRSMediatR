using CQRSMediatR.Data.Query;
using CQRSMediatR.Models;
using CQRSMediatR.Services;
using MediatR;

namespace CQRSMediatR.Data.Handler
{
    public class GetEmployeeByIdHandler : IRequestHandler<GetEmployeeByIdQuery, Employee?>
    {
        private readonly IEmployeeService _employeeService;

        public GetEmployeeByIdHandler(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<Employee?> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await _employeeService.GetEmployeeByIdAsync(request.Id);
        }
    }
}

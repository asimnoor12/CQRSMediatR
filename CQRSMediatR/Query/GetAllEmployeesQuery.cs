using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Query
{
    public record GetAllEmployeesQuery : IRequest<List<Employee>>;
}

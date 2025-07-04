using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Data.Query
{
    public record GetAllEmployeesQuery : IRequest<List<Employee>>;
}

using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Query
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<Employee?>;
}

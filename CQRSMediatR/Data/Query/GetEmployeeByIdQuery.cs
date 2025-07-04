using CQRSMediatR.Models;
using MediatR;

namespace CQRSMediatR.Data.Query
{
    public record GetEmployeeByIdQuery(int Id) : IRequest<Employee?>;
}

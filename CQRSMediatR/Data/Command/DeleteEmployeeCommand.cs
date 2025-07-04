using MediatR;

namespace CQRSMediatR.Data.Command
{
    public record DeleteEmployeeCommand(int Id) : IRequest<int>;
}

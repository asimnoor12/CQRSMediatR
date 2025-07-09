using MediatR;

namespace CQRSMediatR.Command
{
    public record DeleteEmployeeCommand(int Id) : IRequest<int>;
}

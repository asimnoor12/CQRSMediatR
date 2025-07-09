using MediatR;

namespace CQRSMediatR.Command
{
    public record UpdateEmployeeCommand(int Id, string Name, string Address, string Email, string Phone) : IRequest<int>;
}

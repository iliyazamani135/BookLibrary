using MediatR;

namespace Application.Users
{
    public record CreateUserCommand(string FirstName, string LastName, string Email) : IRequest<Guid>;
}

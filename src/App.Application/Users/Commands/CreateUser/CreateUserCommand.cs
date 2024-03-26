using MediatR;

namespace App.Application.Users.Commands.CreateUser;
public record CreateUserCommand(string UserName,  string Email) : IRequest<CreateUserCommandResult>;

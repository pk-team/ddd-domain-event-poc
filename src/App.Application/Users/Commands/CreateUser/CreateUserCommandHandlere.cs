using MediatR;

namespace App.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResult> {
    public Task<CreateUserCommandResult> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
        throw new NotImplementedException();
    }
}
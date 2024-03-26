using App.Domain.Users;

using MediatR;

namespace App.Application.Users.Commands.CreateUser;

public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, CreateUserCommandResult> {
    public Task<CreateUserCommandResult> Handle(CreateUserCommand request, CancellationToken cancellationToken) {
        var user = User.Create(request.UserName, request.Email);
        var reuslt = new CreateUserCommandResult(user.Id, user.UserName, user.Email);
        return Task.FromResult(reuslt);
    }
}
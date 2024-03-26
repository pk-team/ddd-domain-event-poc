namespace App.Application.Users.Commands.CreateUser;
public record CreateUserCommandResult(Guid Id, string UserName, string Email);
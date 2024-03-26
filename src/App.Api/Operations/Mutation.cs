using App.Application.Users.Commands.CreateUser;

using MediatR;

using Microsoft.Identity.Client;

namespace App.Api.Operations;

public class Mutation {

    public async Task<CreateUserCommandResult> CreateUserAsync(
        [Service] ISender sender,
        CreateUserCommand input
        ) {
        var result =  await sender.Send(input);
        return result;
    }

}
using App.Domain.Users.Events;

using MediatR;

namespace App.Application.Users.Events;

public class UserCreatedEventHandler : INotificationHandler<UserCreatedEvent> {

    public Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken) {
        Console.WriteLine($"User created: {notification.Id} - {notification.UserName} - {notification.Email}");
        return Task.CompletedTask;
    }
}
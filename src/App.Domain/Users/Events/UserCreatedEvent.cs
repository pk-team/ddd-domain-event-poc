using App.Domain.Common.Interfaces;

namespace App.Domain.Users.Events;

public class UserCreatedEvent : IDomainEvent {
    public UserCreatedEvent(Guid id, string userName, string email) {
        Id = id;
        UserName = userName;
        Email = email;
    }

    public Guid Id { get; }
    public string UserName { get; }
    public string Email { get; }
}
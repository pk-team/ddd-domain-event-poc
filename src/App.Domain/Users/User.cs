using App.Domain.Common;

namespace App.Domain.Users;

public class User : Entity {
    
    public string UserName { get; private set; } = null!;
    public string Email { get; private set; } = null!;


    private User() {
        // Required by EF
    }

    private User(string userName, string email): base() {
        UserName = userName;
        Email = email;
    }

    public static User Create(string userName, string email) {
        return new User(userName, email);
    }

    public void Update(string userName, string email) {
        UserName = userName;
        Email = email;
    }

}
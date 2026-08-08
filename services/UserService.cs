public class UserService
{
    private readonly List<User> users = new();

    public CreateUserResponse createUser(CreateUserRequest createUserRequest)
    {
        var user = new User(createUserRequest.email, createUserRequest.fname, createUserRequest.lname );
        users.Add(user);
        return new CreateUserResponse
        {
                fname = user.firstName,
                lname =user.lastName,    
                email = user.email,
                login = user.login
        };
    }
    
    public List<User> getUsers()
    {
        return users;
    }
}
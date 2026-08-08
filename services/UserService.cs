public class UserService
{
    private static readonly List<User> users = new();

    private static User findUserByLogin(String login)
    {
        foreach (User item in users)
        {
            if (item.login.Equals(login))
            {
                return  item;
            }
        }
        return null;
        
    }

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

    public List<User> getUserByLogin(string login)
    {
        List<User> result = new();
        if (findUserByLogin(login) != null)
        {
           result.Add(findUserByLogin(login));
            
        }
        return result;
    }

    public int DeleteUserByLogin(String login)
    {
       User deleteUser =  findUserByLogin(login);
       users.Remove(deleteUser);
       return 0;
    }

}
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]  
public class UsersController: ControllerBase
{
    private readonly UserService userService;

    public UsersController(UserService userService)
    {
        this.userService = userService;
    }
 
    [HttpGet("{login}")]
    public IActionResult GetUserByLogin(string login)
    {

        return Ok(userService.getUserByLogin(login));
    }

    [HttpGet]
    public IActionResult GetListOfUsers()
    {

        return Ok(userService.getUsers());
    }

    [HttpDelete]
    public IActionResult DeleteUserByLogin(string login)
    {
        return Ok(userService.DeleteUserByLogin(login));
    }

    [HttpPost]
    public IActionResult CreateUser(CreateUserRequest createUserRequest)
    {
        var result = userService.createUser(createUserRequest);   
        return Ok(result);
    }

}
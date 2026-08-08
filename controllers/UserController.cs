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
 
    [HttpGet]
    public IActionResult GetListOfUsers()
    {

        return Ok(userService.getUsers());
    }


    [HttpPost]
    public IActionResult CreateUser(CreateUserRequest createUserRequest)
    {
        var result = userService.createUser(createUserRequest);   
        return Ok(result);
    }

}
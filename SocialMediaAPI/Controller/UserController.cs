using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly iUserService _userService;

    public UserController(iUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("Register")]
    public async Task<IActionResult> RegisterUser([FromBody] UserRegister model)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var registerResult = await _userService.RegisterUserAsync(model);
        if (registerResult)
            return Ok("User was registered!");

        return BadRequest("User could not be registered.");
    }
    
}
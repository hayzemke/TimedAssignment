using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


[Route("[controller]")]
public class PostController : ControllerBase
{
    private readonly IPostService _service;
    public PostController(IPostService service)
    {
        _service = service;
    }

    [HttpPost("PostMedia")]
    public async Task<IActionResult> PostMedia ([FromForm] PostCreate model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var postResult = await _service.RegisterPostAsync(model);
        if (postResult)
        {
            return Ok("Media was posted");
        }
        return BadRequest("Media could not be posted");
    }
}

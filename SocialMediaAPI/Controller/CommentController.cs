using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IComment _commentService;

        public CommentController(IComment commentService)
        {
            _commentService=commentService;
        }

        [HttpPost("Create Comment")]
        public async Task<IActionResult> CreateComment([FromForm] CommentDetail model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var commentCreated = await _commentService.CreateCommentAsync(model);
            if (commentCreated)
                return Ok("Comment was added");

            return BadRequest("Comment was not added");
        }



    }

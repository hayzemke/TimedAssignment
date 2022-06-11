using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly iComment _commentService;

        public CommentController(iComment commentService)
        {
            _commentService=commentService;
        }

        [HttpPost("Create Comment")]
        public async Task<IActionResult> CreateComment([FromBody] CommentDetail model)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var commentCreated = await _commentService.CreateCommentAsync(model);
            if (commentCreated)
                return Ok("Comment was added");

            return BadRequest("Comment was not added");
        }



    }

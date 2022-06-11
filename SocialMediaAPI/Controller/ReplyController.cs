using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

    [Route("[controller]")]
    public class ReplyController : ControllerBase
    {
        private readonly IReplyService _service;
        
        public ReplyController(IReplyService service)
        {
            _service = service;
        }
        //This is where the [HttpGets] would go
        //this is where crud is called
    }
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ReplyService : IReplyService
    {
        private readonly SocialMedia_DbContext _context;
        public ReplyService(SocialMedia_DbContext context)
        {
            _context = context;
        }
        public async Task<bool>CreateReply(ReplyCreate reply)
        {
            
        }
        public async Task<IEnumerable<ReplyListItem>>GetItems()
        {

        }
        //This is where the crud happens
    }
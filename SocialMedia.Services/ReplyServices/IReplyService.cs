using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IReplyService
    {
        Task<bool>CreateReply(ReplyCreate reply);
        Task<IEnumerable<ReplyListItem>>GetItems();
    }
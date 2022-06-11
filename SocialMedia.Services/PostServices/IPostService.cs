using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IPostService
    {
        Task<bool> RegisterPostAsync(PostModel model);
         Task<IEnumerable<PostListItem>> GetPostListItemsAsync();
    }

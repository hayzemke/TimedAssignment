using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public interface IPostService
    {
        Task<bool> RegisterPostAsync(PostCreate model);
         Task<IEnumerable<PostListItem>> GetPostListItemsAsync();
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class PostService : IPostService
    {
        private readonly SocialMedia_DbContext _context;
        private readonly int _postID;
        public PostService(SocialMedia_DbContext context)
        {
            _context = context;
        }
        public async Task<bool> RegisterPostAsync(PostModel model)
        {
            var entity = new Post
            {
                Title = model.Title,
                Text = model.Text,
                Comments = model.Comments,
                Likes = model.Likes
            };
            _context.Posts.Add(entity);
            var numberOfChanges = await _context.SaveChangesAsync();
            return numberOfChanges == 1;
        }

        public async Task<IEnumerable<PostListItem>> GetPostListItemsAsync()
        {
            var posts = await _context.Posts
            .Where(entity => entity.ID == _postID)
            .Select(entity => new PostListItem
            {
                Id = entity.ID,
                Title = entity.Title,
            })
            .ToListAsync();
        return posts;
        }
    }

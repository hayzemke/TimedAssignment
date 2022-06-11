using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class CommentService : IComment
{
    private readonly SocialMedia_DbContext _context;
    public CommentService(SocialMedia_DbContext context)
    {
        _context = context;
    }
    public async Task<bool> CreateCommentAsync(CommentDetail model)
    {
        var comment = new Comment
        {
            Text = model.Text,
            PostID = model.PostID
        };

        _context.Comments.Add(comment);
        var numberOfChanges = await _context.SaveChangesAsync();

        return numberOfChanges == 1;
    }

    public async Task<IEnumerable<CommentDetail>> GetCommentsByPostID(int postID)
    {
        var comments = await _context.Comments
        // .Where(comments => comments.ID == PostID)
        .Select(comments => new CommentDetail
        {
            Text = comments.Text,
        })
        .ToListAsync();

        return comments;
    }
}

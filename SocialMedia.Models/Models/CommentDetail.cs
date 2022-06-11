using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class CommentDetail
{
    [Required]
    public string Text { get; set; }
    public virtual List<Reply> Replies { get; set; }

    [ForeignKey(nameof(Post))]
    public int PostID { get; set; }
    public Post Posts { get; set; }

}
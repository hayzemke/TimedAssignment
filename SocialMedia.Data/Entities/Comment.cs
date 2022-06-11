using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class Comment
{
    [Key]
    public int ID { get; set; }
    [Required]
    public string Text { get; set; }
    public virtual List<Reply> Replies { get; set; }

    [ForeignKey(nameof(Post))]
    public Post Posts { get; set; } 
    public int PostID { get; set; }
    }

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

    public class Post
    {   [Key]
        public int ID { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Text { get; set; }
        
        public virtual List<Comment> Comments { get; set; }
        public virtual List<Like> Likes { get; set; }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class ReplyCreate
    {
        public int CommentID { get; set; }

        [Required]
        public string Text { get; set; }
    }
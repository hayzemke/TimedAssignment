using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

    public class Reply
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey(nameof(Comment))]
        public Comment Comments { get; set; }
        public int CommentID { get; set; }

        [Required]
        public string Text { get; set; }
        
    }

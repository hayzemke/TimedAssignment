using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


    public class PostCreate
    {
        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Text { get; set; }
        
    }

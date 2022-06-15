using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

public class UserEntity
    {   [Key]
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime DateJoined { get; set; }
    }

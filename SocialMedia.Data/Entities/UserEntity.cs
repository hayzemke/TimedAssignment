using System.ComponentModel.DataAnnotations;

public class UserEntity
    {   [Key]
        public int ID { get; set; }

        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }

        public DateTime DateJoined { get; set; }
    }

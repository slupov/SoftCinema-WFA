namespace SoftCinema.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class User
    {
        public User()
        {
            this.Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        [Required,MaxLength(25),Index(IsUnique = true)]
        public string Username { get; set; }
        
        //TODO: Stoyo include password hasher class
        [Required]
        public byte[] PasswordHash { get; set; }

        [RegularExpression("0([0-9]{9})", ErrorMessage = "Invalid phone number.")]
        public string PhoneNumber { get; set; }

        [Required, EmailAddress,MaxLength(30),Index(IsUnique = true)]
        public string Email { get; set; }

        public Role Role { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class User
    {
        public User()
        {
            Tickets = new HashSet<Ticket>();
        }

        [Key]
        public int Id { get; set; }

        //TODO: Stoyo include password hasher class
        [Required]
        public byte[] PasswordHash { get; set; }

        [RegularExpression("0([0-9]{9})", ErrorMessage = "Invalid phone number.")]
        public string Phone { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        //make Enum in the future
        public string Role { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
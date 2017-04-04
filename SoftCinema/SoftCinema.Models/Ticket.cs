using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int HolderId { get; set; }

        public virtual User Holder { get; set; }

        [Required]
        public int ShowId { get; set; }

        public virtual Show Show { get; set; }

        [Required]
        public byte Row { get; set; }

        [Required]
        public byte Col { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        //make enum in the future
        public string Type { get; set; }
    }
}
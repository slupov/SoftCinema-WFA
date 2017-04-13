using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.DTOs
{
    
    public class ScreeeningDto
    {
        public byte AuditoriumNumber { get; set; }

        public string CinemaName { get; set; }

        public string CinemaTown { get; set; }

        public DateTime Date { get; set; }

        public string MovieName { get; set; }

        public int MovieReleaseYear { get; set; }
    }
}

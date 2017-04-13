using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.DTOs
{
    public class SeatDto
    {
        public string CinemaName { get; set; }

        public string CinemaTown { get; set; }

        public byte AuditoriumNumber { get; set; }

        public int Row { get; set; }

        public int Number { get; set; }
    }
}

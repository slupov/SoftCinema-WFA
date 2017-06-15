using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Services.Utilities.Validators
{
    public class AuditoriumValidator
    {
        private readonly AuditoriumService auditoriumService;

        public AuditoriumValidator(AuditoriumService auditoriumService)
        {
            this.auditoriumService = auditoriumService;
        }

        public void ValidateAuditoriumDoesNotExist(byte number, int cinemaId, string cinemaName)
        {
            if (auditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.AuditoriumAlreadyExists, number, cinemaName));
            }
        }

        public void CheckAuditoriumExists(byte number, int cinemaId, string cinemaName)
        {
            if (!auditoriumService.IsAuditoriumExisting(number, cinemaId))
            {
                throw new InvalidOperationException(string.Format(Constants.ErrorMessages.AuditoriumDoesntExist, number, cinemaName));
            }
        }
    }
}

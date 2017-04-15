using System;
using System.Collections.Generic;
using SoftCinema.DTOs;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class DataValidator
    {
        public static void ValidateStringMaxLength(string input, int length)
        {
            if (input.Length > length)
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.StringExceedsLength, length));
            }
        }

        public static void ValidateFloatInRange(float? input, int minValue, int maxValue)
        {
            if (input != null && (input < minValue || input > maxValue))
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.FloatNotInRange, minValue, maxValue));
            }
        }
    }
}

using System;

namespace SoftCinema.Services.Utilities.Validators
{
    public static class InputDataValidator
    {
        public static void ValidateStringMaxLength(string input, int length)
        {
            if (!InputDataChecker.CheckStringMaxLength(input, length))
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.StringExceedsLength, length));
            }
        }

        public static void ValidateFloatInRange(float? input, float minValue, float maxValue)
        {
            if (input != null && !InputDataChecker.CheckFloatInRange(input.Value, minValue, maxValue))
            {
                throw new ArgumentException(string.Format(Constants.ErrorMessages.FloatNotInRange, minValue, maxValue));
            }
        }
    }
}
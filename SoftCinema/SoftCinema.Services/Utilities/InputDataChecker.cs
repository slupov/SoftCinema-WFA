using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftCinema.Services.Utilities
{
    public static class InputDataChecker
    {
        public static bool CheckStringMinMaxLength(string input,int minLength, int maxLength)
        {
            return input.Length >= minLength && input.Length <= maxLength;
        }

        public static bool CheckStringMaxLength(string input, int maxLength)
        {
            return input.Length <= maxLength;
        }

        public static bool CheckFloatInRange(float input, float minValue, float maxValue)
        {
            return input >= minValue && input <= maxValue;
        }
    }
}

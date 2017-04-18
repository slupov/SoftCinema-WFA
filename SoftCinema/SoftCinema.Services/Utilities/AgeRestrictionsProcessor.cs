namespace SoftCinema.Services.Utilities
{
    using SoftCinema.Models;
    using System;
    using System.Collections.Generic;
    public class AgeRestrictionsProcessor
    {
        public static string[] GetAgeRestrictions()
        {
            List<string> ageRs = new List<string>();
            foreach (var ageR in Enum.GetValues(typeof(AgeRestriction)))
            {
                ageRs.Add(ageR.ToString());
            }
            return ageRs.ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace ActivityLoggerApp.Helpers
{
    public static class ModelExtensions
    {
        public static string ToFriendlyString(this Enums.BikeType me)
        {
            switch (me)
            {
                case Enums.BikeType.Road:
                    return "Road";
                case Enums.BikeType.CycloCross:
                    return "Cyclo Cross";
                case Enums.BikeType.Mountain:
                    return "Mountain";
                case Enums.BikeType.TimeTrial:
                    return "Time Trial";
                case Enums.BikeType.Tourer:
                    return "Tourer";
                case Enums.BikeType.Track:
                    return "Track";
                case Enums.BikeType.BMX:
                    return "BMX";
                default:
                    return "NOT SET";
            }
        }

        public static Guid GetUserId()
        {
            return (Guid)Membership.GetUser().ProviderUserKey;
        }
    }
}
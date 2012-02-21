using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ActivityLoggerApp.Models.Interfaces;
using ActivityLoggerApp.Models.Activities;

namespace ActivityLoggerApp.Models.Factories
{
    public class ActivityFactory : IActivity
    {
        Activity activity;

        public Activity CreateActivity(String activityType)
        {
            switch (activityType)
            {
                case "Ride":
                    activity = new RideActivity();
                    break;
                case "Run":
                    activity = new RunActivity();
                    break;
                case "Walk":
                    activity = new WalkActivity();
                    break;
            }

            return activity;
        }
    }
}
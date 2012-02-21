using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ActivityLoggerApp.Models.Interfaces
{
    interface IActivity
    {
        Activity CreateActivity(String activityType);
    }
}

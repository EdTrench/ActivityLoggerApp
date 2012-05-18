using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;
using ActivityLoggerApp.Models.Activities;

namespace ActivityLoggerApp.Repositories.Interfaces
{
    public interface IRideRepository
    {
        void Add(RideActivity ride);
        void Update(RideActivity ride);
        void Remove(RideActivity ride);
        RideActivity GetById(Int64 id);
        List<RideActivity> GetAll();
    }
}

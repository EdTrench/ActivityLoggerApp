﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Repositories
{
    interface IBikeRepositry
    {
        void Add(Bike bike);
        void Update(Bike bike);
        void Remove(Bike bike);
        Bike GetById(Int64 id);
        IList<Bike> GetAll();
    }
}

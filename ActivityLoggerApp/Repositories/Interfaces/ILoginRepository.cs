using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Repositories.Interfaces
{
    interface ILoginRepository
    {
        void Add(Login login);
        void Update(Login login);
        void Remove(Login login);
        Login GetById(Guid id);
        List<Login> GetAll();
    }
}

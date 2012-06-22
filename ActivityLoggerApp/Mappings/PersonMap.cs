using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Mappings
{
    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            HasMany(x => x.Bikes)
                .Not.LazyLoad()
                .KeyColumn("Id")
                .Inverse();
            Map(x => x.Name);
            Map(x => x.Weight);
            Map(x => x.Dob);
            Map(x => x.Category);
            Map(x => x.UserId);
        }
    }
}
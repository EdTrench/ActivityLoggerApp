using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentNHibernate.Mapping;
using ActivityLoggerApp.Models;

namespace ActivityLoggerApp.Mappings
{
    public class BikeMap : ClassMap<Bike>
    {
        public BikeMap()
        {
            Id(x => x.Id)
                .GeneratedBy.Identity();
            References(x => x.Person)
                .Not.LazyLoad()
                .Column("PersonId");
            Map(x => x.Name);
            Map(x => x.Type);
        }
    }
}
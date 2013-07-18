using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using WindowsFormsApplication1.Domain;

namespace WindowsFormsApplication1.Mapping
{
    public class CustomerMap: ClassMap<Customers>
    {
        public CustomerMap()
        {
            Id(x => x.id);
            Map(x => x.Name).Not.Nullable();
            Map(x => x.status).Not.Nullable();
        }
    }
}

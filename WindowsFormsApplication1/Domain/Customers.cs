using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Domain
{
    public class Customers
    {
        public virtual int id { get; set; }
        public virtual string Name { get; set; }
        public virtual bool status { get; set; }
    }
}

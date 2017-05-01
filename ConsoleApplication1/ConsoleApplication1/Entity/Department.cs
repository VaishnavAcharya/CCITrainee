using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Department
    {
        public virtual int dept_id { get; protected set; }
        public virtual string name { get; set; }

        public virtual IList<Employee> Employees { get; set; }

    }
}

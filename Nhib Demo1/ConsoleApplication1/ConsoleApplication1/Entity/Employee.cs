using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        public virtual int employee_id { get; protected set; }
        public virtual string name { get; set; }

        public virtual Department department { get; set; }
    }
}

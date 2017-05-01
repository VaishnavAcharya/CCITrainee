using ConsoleApplication1;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApplication1
{
    class EmployeeMap : ClassMapping<Employee>
    {
        public EmployeeMap()
        {
            Lazy(false);
            Cache(x => x.Usage(CacheUsage.NonstrictReadWrite));
            Table("Employee");


            Id(x => x.employee_id, map => { map.Column("EmpId"); map.Generator(Generators.Identity); });

            Property(x => x.name);

            ManyToOne(x => x.department, map => { map.Column("DeptId"); map.NotNullable(true); map.Cascade(Cascade.None); });
        }
    }
}

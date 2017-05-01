using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Mapping
{
    class DepartmentMap: ClassMapping<Department>
    {
        public DepartmentMap()
        {
            Lazy(true);
            Cache(x => x.Usage(CacheUsage.NonstrictReadWrite));
            Table("Dept");

            Id(x => x.dept_id, map => { map.Column("DeptID"); map.Generator(Generators.Identity); });
            Property(x => x.name, map => { map.Column("DeptName"); });

            Bag(x => x.Employees, colmap => { colmap.Key(x => x.Column("DeptID")); colmap.Inverse(true); }, map => map.OneToMany(x => x.Class(typeof(Employee))));
        }
    }
}


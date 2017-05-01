using NHibernate;
using NHibernate.Caches.SysCache;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class mainClass
    {
        public static void Main(string [] args)
        {
            Program p = new Program();

            ISession session = p.getDBSession();

            Department d;
            d = session.Get<Department>(1);

            Department d2;
            d2 = session.Load<Department>(2);

            Employee e1;
            e1 = session.Get<Employee>(1);

            Employee e2;
            e2 = session.Load<Employee>(1);

            e1 = session.Get<Employee>(2);

            Department d3;
            d3 = session.Load<Department>(3);

            Employee e3 = new Employee();
            e3.name = "bbb";
            e3.department = d;
            session.Save(e3);

            e3 = session.Get<Employee>(e3.employee_id);
            e3.name = "ccc";
            session.Update(e3);
            session.Flush();

        }

    }

    class Program
    {
        private readonly ISessionFactory _nhibSessionFactory;

        public Program()
        {
            _nhibSessionFactory = InitializeNHibernate();

        }


        public void addNewEmploee(Employee e)
        {
            using (ISession session = _nhibSessionFactory.OpenSession())
            {
                using (ITransaction transaction = session.BeginTransaction())
                {
                    session.Save(e);
                    transaction.Commit();
                }

            }

        }

        public ISession getDBSession()
        {
            return _nhibSessionFactory.OpenSession();
        }


        private ISessionFactory InitializeNHibernate()
        {
            // This creates a configuration, then locates mappers, then creates a Nhibernate ISessionFactory instance
            // It's somewhat heavy weight object so you want to do this only on app startup once

            // SessionFactory is immutable, and any configuration / mapping changes done after BuildSessionFactory has no effect.

            var mapper = new ModelMapper();
            mapper.AddMappings(GetMappingsFromAssenbly(Assembly.GetExecutingAssembly()));

            var connectionString = "Data Source=CCI-LPT-15\\MSSQLSERVER2K14E;initial catalog=EmployeeService;user id=sa;password=sa123456#;persist security info=False";

            var cfg = new Configuration();
            cfg.DataBaseIntegration(c =>
            {
                c.ConnectionString = connectionString;
                c.Driver<SqlClientDriver>();
                c.Dialect<MsSql2012Dialect>();
                c.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
            });

            cfg.SetProperty("default_batch_fetch_size", "15");
            cfg.Cache(c => { c.Provider<SysCacheProvider>(); c.UseQueryCache = true; });
            cfg.Mappings(x => x.DefaultSchema = "dbo");
            cfg.AddMapping(mapper.CompileMappingForAllExplicitlyAddedEntities());

            /*
            NHibEventsListener eventsListner = new NHibEventsListener();
            cfg.SetListener(global::NHibernate.Event.ListenerType.PostInsert, eventsListner);
            cfg.SetListener(global::NHibernate.Event.ListenerType.PreUpdate, eventsListner);
            cfg.SetListener(global::NHibernate.Event.ListenerType.PreDelete, eventsListner);
            */


            return cfg.BuildSessionFactory();
        }


        private IEnumerable<Type> GetMappingsFromAssenbly(Assembly assembly)
        {
            // Returns all classes derived from ClassMapping<> & which are not abstract.
            return assembly.GetTypes().Where(t => !t.IsAbstract
                                                  && t.GetBaseTypes().Any(bt => bt.IsGenericType && bt.GetGenericTypeDefinition() == typeof(ClassMapping<>))
                                            );
        }

    }
}

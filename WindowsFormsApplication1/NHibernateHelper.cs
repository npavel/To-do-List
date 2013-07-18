using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace WindowsFormsApplication1
{
    public class NHibernateHelper
    {
        private static ISessionFactory _session;

        private static ISessionFactory session
        {
            get
            {
                if (_session == null) CreateSession();
                return _session;
            }

            
        }

        private static void CreateSession()
        {
            _session = Fluently.Configure().
                Database(MsSqlConfiguration.MsSql2008
                .ConnectionString(c => c.FromConnectionStringWithKey("conStr")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new NHibernate.Tool.hbm2ddl.SchemaExport(cfg)
                .Create(true, true))
                .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return session.OpenSession();
        }
        
    }
}

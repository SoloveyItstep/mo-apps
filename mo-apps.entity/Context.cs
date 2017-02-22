using mo_apps.entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mo_apps.entity
{
    public class Context: DbContext
    {
        public Context()
            :this("MoApps")
        {
            
        }

        public Context(String connectionString)
            :base(connectionString)
        {
            Database.SetInitializer<Context>(new DropCreateDatabaseIfModelChanges<Context>());
        }

        public DbSet<User> User {get;set;}
        public DbSet<Points> Points { get; set; }
        public DbSet<Honor> Honor { get; set; }

    }
}

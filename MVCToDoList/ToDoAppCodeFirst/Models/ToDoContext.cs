using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ToDoAppCodeFirst.Models
{
    public class ToDoContext : DbContext
    {
        public ToDoContext():base ("ToDoEntities")
        {

        }

        public DbSet<Tasks> Tasks { get; set; }

    }

    public class ToDoDBCreator : DropCreateDatabaseIfModelChanges<ToDoContext>
    {

    }

}
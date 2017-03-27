namespace ToDoAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDoContext : DbContext
    {
        public ToDoContext()
            : base("name=ToDoContext")
        {

        }

        public DbSet<Tasks> Tasks { get; set; }

    }

    public class DbCreator:DropCreateDatabaseIfModelChanges<ToDoContext>
    {

    }
}

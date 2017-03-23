namespace ToDoAppFromScratch.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ToDoEntity : DbContext
    {
        public ToDoEntity()
            : base("name=ToDoEntity")
        {

        }

        public DbSet<Tasks> Tasks { get; set; }
        
          
    }

    public class ToDoDBCreator : DropCreateDatabaseIfModelChanges<ToDoEntity>
    {

    }
}

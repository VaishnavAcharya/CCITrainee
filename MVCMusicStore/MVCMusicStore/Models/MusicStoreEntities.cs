namespace MVCMusicStore.Models
{
    using System.Data.Entity;

    public partial class MusicStoreEntities : DbContext
    {
        //public System.Data.Entity.DbSet<MVCMusicStore.Models.Album> Albums { get; set; }

        //public System.Data.Entity.DbSet<MVCMusicStore.Models.Artist> Artists { get; set; }

        //public System.Data.Entity.DbSet<MVCMusicStore.Models.Genre> Genres { get; set; }
        public MusicStoreEntities()
            : base("name=MusicStoreEntities")
        {
        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

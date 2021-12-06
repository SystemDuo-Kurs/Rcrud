using Microsoft.EntityFrameworkCore;
using Rcrud.Shared;

namespace Rcrud.Server
{
    public class Db : DbContext
    {
        public Db(DbContextOptions<Db> o) : base(o) { }

        public DbSet<Osoba> Osobas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Osoba>().HasKey(o => o.Id);

            modelBuilder.Entity<Osoba>().HasData(new Osoba[]
            {
                new Osoba{Id=-1, Godiste=83, Name="Pera", Surname="Peric"},
                new Osoba{Id=-2, Godiste=35, Name="Neko", Surname="Nekic"},
                new Osoba{Id=-3, Godiste=345, Name="Trecko", Surname="Treckovic"},
                new Osoba{Id=-4, Godiste=83, Name="Asd", Surname="Qwe"}
            });
        }
    }
}

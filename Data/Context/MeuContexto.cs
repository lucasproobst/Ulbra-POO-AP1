using AP1;
using Microsoft.EntityFrameworkCore;

namespace Data.Context
{
    public class MeuContexto : DbContext
    {
        protected string DbPath { get; }
        public MeuContexto()
        {
            string path = Directory.GetCurrentDirectory();
            DbPath = System.IO.Path.Join(path, "TestandoORM.db");
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Produto> Produtos { get; set; }
    }
}
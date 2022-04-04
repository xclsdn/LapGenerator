using Microsoft.EntityFrameworkCore;

namespace LapGenerator.Models
{
    public class LapContext:DbContext
    {
        public string DbPath { get; }
        public LapContext()

        {
            //var folder = Environment.SpecialFolder.LocalApplicationData;
            var folder = Environment.SpecialFolder.MyDocuments;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "LapGenerator.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
                            => options.UseSqlite($"Data Source={DbPath}");

        public DbSet<Race> Races { get; set; }
    }
}

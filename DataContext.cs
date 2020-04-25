using Microsoft.EntityFrameworkCore;
using Project_Bomject1.Models;

namespace Project_Bomject1
{
    public class DataContext : DbContext
    {
        public DbSet<ThemeOfTheDayModel> ThemesOfTheDay { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

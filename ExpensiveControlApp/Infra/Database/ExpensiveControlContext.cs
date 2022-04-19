using ExpensiveControlApp.Models.Expensives;
using Microsoft.EntityFrameworkCore;

namespace ExpensiveControlApp.Infra.Database
{
    public class ExpensiveControlContext : DbContext
    {
        public DbSet<Expensive> Expensives { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("Data Source=ExpensiveControl.db");
    }
}

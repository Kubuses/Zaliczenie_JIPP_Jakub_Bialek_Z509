using Microsoft.EntityFrameworkCore;
using Zaliczenie_JIPP_Jakub_Bialek.Models;

namespace Zaliczenie_JIPP_Jakub_Bialek.Data
{
    public class ProgrammingBookContext : DbContext
    {
        public virtual DbSet<ProgrammingBookModel> ProgrammingBooks { get; set; }

        public ProgrammingBookContext(DbContextOptions<ProgrammingBookContext> options)
            : base(options)
        {

        }

        public ProgrammingBookContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace ThiThuMayConGa.Model
{
    public class DbContextApp : DbContext
    {
        public DbContextApp()
        {

        }
        public DbContextApp(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=VGiap;Initial Catalog=DemoBlazor;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;

namespace CRUDSample.Models
{
	public class DatabaseContext : DbContext
	{
        public DatabaseContext() { }

        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<ProductModel> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ProductModel>().HasKey(p => p.Id);
            modelBuilder.Entity<ProductModel>().Property(p => p.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<ProductModel>().Property(p => p.NamaBarang).HasMaxLength(250);
            modelBuilder.Entity<ProductModel>().Property(p => p.Harga).HasColumnType("decimal(18,2)");
            modelBuilder.Entity<ProductModel>().Property(p => p.Stok).HasColumnType("int");
            modelBuilder.Entity<ProductModel>().Property(p => p.CreatedAt).HasColumnType("datetime");
            modelBuilder.Entity<ProductModel>().Property(p => p.CreatedAt).HasDefaultValueSql("getdate()");
        }
    }
}
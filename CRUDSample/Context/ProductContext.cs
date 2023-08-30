namespace waterlevel_netcore.Models
{
	public class ProductContext : DbContext
	{
        public ProductContext() { }

        public ProductContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<ProductContext> ultrasoniks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured) {
                
            }
        }
    }
}
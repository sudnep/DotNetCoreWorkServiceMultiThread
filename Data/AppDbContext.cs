using Microsoft.EntityFrameworkCore;

namespace ApplicationCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
         : base(options)
        {
        }

        public DbSet<EntityCodeMap> EntityCodeMaps { get; set; }
        public DbSet<DocTypeMap> DocTypeMaps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MIS1DEVBIZ7N;Database=FileTransferV2;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<EntityCodeMap>(entity =>
            {
                entity.ToTable("EntityCodeMap", "eFrontFileResolver")
                      .HasKey("EntityCodeMapId");
            });
            modelBuilder.Entity<DocTypeMap>(entity =>
            {
                entity.ToTable("DocTypeMap", "eFrontFileResolver")
                      .HasKey("DocTypeMapId");
            });
        }
    }
}
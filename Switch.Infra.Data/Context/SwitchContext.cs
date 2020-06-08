using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Config;

namespace Switch.Infra.Data.Context
{
    public class SwitchContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        public DbSet<StatusRelacionamento> StatusRelacionamento { get; set; }

        public SwitchContext()
        {

        }

        public SwitchContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("Server=localhost;Database=switch;Uid=root;Pwd=jofamo/*2019");
            }

            base.OnConfiguring(optionsBuilder);
        }
    }
}
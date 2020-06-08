using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class PostagemConfiguration : IEntityTypeConfiguration<Postagem>
    {
        public void Configure(EntityTypeBuilder<Postagem> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.DataPublicacao).IsRequired();
            builder.Property(u => u.Texto).HasColumnType("longtext").IsRequired();
        }
    }
}
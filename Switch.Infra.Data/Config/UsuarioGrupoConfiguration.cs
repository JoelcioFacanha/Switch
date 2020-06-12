using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;

namespace Switch.Infra.Data.Config
{
    public class UsuarioGrupoConfiguration : IEntityTypeConfiguration<UsuarioGrupo>
    {
        public void Configure(EntityTypeBuilder<UsuarioGrupo> builder)
        {
            // Configurando chave composta
            builder.HasKey(ug => new { ug.UsuarioId, ug.GrupoId });
            builder.Property(ug => ug.DataCriacao).IsRequired();
            builder.Property(ug => ug.isAdmin);
        }
    }
}
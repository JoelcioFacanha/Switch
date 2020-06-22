using Microsoft.EntityFrameworkCore;
using Switch.Domain.Entities;
using Switch.Infra.Data.Context;
using System;

namespace SwitchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new Usuario()
            {
                Nome = "Usuario1",
                SobreNome = "SobreNomeUsuario",
                Email = "usuario@gmail.com",
                DataNascimento = DateTime.Parse("30/06/1977"),
                Senha = "123456",
                UrlFoto = "fotos/foto1.png"
            };

            var optionsBuilder = new DbContextOptionsBuilder<SwitchContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;Database=switch;Uid=root;Pwd=jofamo/*2019", m => m.MigrationsAssembly(nameof(Switch.Infra.Data)));

            using (var context = new SwitchContext(optionsBuilder.Options))
            {
                context.Usuarios.Add(user);
                context.SaveChanges();
            }
        }
    }
}

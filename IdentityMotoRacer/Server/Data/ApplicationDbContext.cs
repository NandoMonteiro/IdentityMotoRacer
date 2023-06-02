using Duende.IdentityServer.EntityFramework.Options;
using IdentityMotoRacer.Server.Entities;
using IdentityMotoRacer.Server.Models;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace IdentityMotoRacer.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)        
        {
        }
        public DbSet<Categoria>? Categorias { get; set; }
        public DbSet<Cliente>? Clientes { get; set; }
        public DbSet<ItemServico>? ItemServicos { get; set; }
        public DbSet<Locacao>? Locacaos { get; set; }
        public DbSet<Pagamento>? Pagamentos { get; set; }
        public DbSet<LocacaoItemServico>? ItemServicolocacoes { get; set; }
        public DbSet<Veiculo>? Veiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Categoria>().HasData(new Categoria
            {
                Id= 1,
                Tipo = "Speed",
                Descricao = "Moto destinada a performace."
            });
            modelBuilder.Entity<Veiculo>().HasData(new Veiculo
            {
                Id= 1,
                Placa = "XPT0201",
                Modelo = "Moto destinada a performace.",
                Marca = "Yamaha",
                Cilindrada = 1000,
                Cor = "Branca",
                Ano = 2022,
                Renavam = "1234567",
                ValorDiaria = 100,
                Quilometragem = 3500,
                ImagemUrl = "/imagens/Speed/yamaha.png",
                CategoriaId = 1
            });

        }

    }
}
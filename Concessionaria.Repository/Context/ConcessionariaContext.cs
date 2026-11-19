using System;
using System.Collections.Generic;
using System.Text;
using Concessionaria.Domain;
using Microsoft.EntityFrameworkCore;

namespace Concessionaria.Repository.Context
{
    public class ConcessionariaContext : DbContext
    {
        public ConcessionariaContext(DbContextOptions<ConcessionariaContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Concessionaria.Domain.Concessionaria> Concessionarias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Venda> Vendas { get; set; }
    }
}

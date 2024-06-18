using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Loja.Models;

namespace Loja.Data
{
    public class LojaContext : DbContext
    {
        public LojaContext (DbContextOptions<LojaContext> options)
            : base(options)
        {
        }

        public DbSet<Loja.Models.Carro> Carro { get; set; } = default!;
        public DbSet<Loja.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Loja.Models.Desconto> Desconto { get; set; } = default!;
        public DbSet<Loja.Models.Usuario> Usuario { get; set; } = default!;
        public DbSet<Loja.Models.Venda> Venda { get; set; } = default!;
    }
}

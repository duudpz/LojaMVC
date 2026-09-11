using Microsoft.EntityFrameworkCore;
using LojaMVC.Models;

namespace LojaMVC.Data { 

public class LojaContext : DbContext
    {

        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
    {
     
            
     }

    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
  
 }
}


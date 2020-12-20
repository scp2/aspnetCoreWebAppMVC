using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria> Categorias
        {
            get;
            set;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                connectionString:@"Server=(sql1:1433);Database=Cursomvc;Integrated Security=True;User Id=SA;Password=sA3AnRyX[AR?"
                );
        }
    }
}
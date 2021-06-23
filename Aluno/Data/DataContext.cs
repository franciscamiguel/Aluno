using AlunoApi.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):
            base(options)
        { }

        public DbSet<Alluno> Alunos { get; set; }
        
        public DbSet<Prof> Professores { get; set; }

        public DbSet<Coordenador> Coordenadores { get; set; }
        
        public DbSet<Director> Directores { get; set; }
    }
}

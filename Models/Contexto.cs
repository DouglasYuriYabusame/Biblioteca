using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibliotecaVesp.Models
{
    public class Contexto: DbContext
    {

        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Livro> Livros { get; set; }
        

        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }


    }
}

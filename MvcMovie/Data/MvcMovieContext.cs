using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Data
{
    public class MvcMovieContext: DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
           : base(options)
        {
        }

#pragma warning disable CS0246 // O nome do tipo ou do namespace "Movie" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
        public DbSet<Movie> Movie { get; set; }
#pragma warning restore CS0246 // O nome do tipo ou do namespace "Movie" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
    }
}

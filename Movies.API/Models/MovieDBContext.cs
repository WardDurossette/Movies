using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;

namespace Movies.API.Models
{

    public class MoviesDBContext : DbContext
    {

        public MoviesDBContext (DbContextOptions<MoviesDBContext> options)
            : base(options)
        {
        }


        public DbSet<MovieViewModel> Movies { get; set; }

    }


}
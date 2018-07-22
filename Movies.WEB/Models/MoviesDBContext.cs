using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Movies.WEB.Models
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
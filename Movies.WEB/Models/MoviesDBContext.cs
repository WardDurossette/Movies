using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Movies.WEB.Models
{

    public class MoviesDBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=movies.db");
        }

        public DbSet<MovieViewModel> Movies { get; set; }

    }

}
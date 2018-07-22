using System;
using System.Collections.Generic;
using Movies.WEB.Models;


namespace Movies.WEB.Services
{

    public class MovieService : IMovieService
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie() {
                    MovieId = 1,
                    MovieTitle = "The Cat In The Hat",
                    ReleaseYear = 1966
                }
            };
        }
    }





}
using System;
using System.Collections.Generic;
using Movies.WEB.Models;


namespace Movies.WEB.Services
{

    public class MovieService : IMovieService
    {
        public List<MovieViewModel> GetMovies() => new List<MovieViewModel>
            {
                new MovieViewModel() {
                    MovieId = 1,
                    MovieTitle = "The Cat In The Hat",
                    ReleaseYear = 2003,
                    Genre = "Musical Comedy/Adventure"
                },
                new MovieViewModel() {
                    MovieId = 2,
                    MovieTitle = "Gone With The Wind",
                    ReleaseYear = 1939,
                    Genre = "Drama/Romance"
                }
            };
    }





}
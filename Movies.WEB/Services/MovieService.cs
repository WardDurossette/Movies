using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Movies.WEB.Models;


namespace Movies.WEB.Services
{

    public class MovieService : IMovieService
    {
        public List<MovieViewModel> GetMovies() => new List<MovieViewModel>
            {
                new MovieViewModel() {
                    MovieID = 1,
                    MovieTitle = "The Cat In The Hat",
                    ReleaseYear = 2003,
                    Genre = "Musical Comedy/Adventure"
                },
                new MovieViewModel() {
                    MovieID = 2,
                    MovieTitle = "Gone With The Wind",
                    ReleaseYear = 1939,
                    Genre = "Drama/Romance"
                }
            };


        public void AddMoviesToDB(MoviesDBContext dbContext)
        {
            MovieService movieService = new MovieService();

         
                foreach(var movie in movieService.GetMovies())
                {
                    MovieViewModel oNew = new MovieViewModel();
                    oNew.MovieTitle = movie.MovieTitle;
                    oNew.ReleaseYear = movie.ReleaseYear;
                    oNew.Genre = movie.Genre;

                    dbContext.Movies.Add(oNew);
                    dbContext.SaveChanges();
                }

         }



    }





}
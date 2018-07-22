using System;
using System.Collections.Generic;
using Movies.WEB.Models;


namespace Movies.WEB.Services
{
    public interface IMovieService
    {

        List<MovieViewModel> GetMovies();



    }
}
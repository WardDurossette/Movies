using System;
using System.ComponentModel.DataAnnotations;

namespace Movies.API.Models
{
    public class MovieViewModel
    {
        [Key]
        public int MovieID { get; set; }

        public string MovieTitle { get; set; }

        public int ReleaseYear { get; set; }

        public string Genre { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieStore.Models.DTO;

namespace MovieStore.DL.Interfaces
{
    internal interface MyMovieRepository
    {
        IEnumerable<Movie> GetMovies();
    }
}

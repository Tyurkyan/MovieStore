﻿using Microsoft.AspNetCore.Mvc;
using MovieStore.DL.Interfaces;
using MovieStore.Models.DTO;
namespace MovieStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MoviesController(
            IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _movieRepository.GetMovies();
        }
    }
}

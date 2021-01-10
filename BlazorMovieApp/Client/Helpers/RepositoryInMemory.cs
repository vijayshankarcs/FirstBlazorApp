using BlazorMovieApp.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieApp.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                    new Movie(){  Title = "Lucifer",ReleaseDate = new DateTime(2019, 8, 5)},
                    new Movie() { Title = "Varane Avashyamund", ReleaseDate = new DateTime(2020, 6, 10) },
                    new Movie(){  Title = "Trance",ReleaseDate = new DateTime(2020, 10, 15)}
                    };
        }
    }
}

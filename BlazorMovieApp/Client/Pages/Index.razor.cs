using BlazorMovieApp.Client.Helpers;
using BlazorMovieApp.Shared.Entities;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMovieApp.Client.Pages
{
    public partial class Index
    {
        [Inject] IRepository repository { get; set; }
        //string name = "vijay";
        //string upercase(string value) => value.ToUpper();



        //Movie Lucifer = new Movie()
        //{
        //    Title = "Lucifer",
        //    ReleaseDate = new DateTime(2019, 8, 5)
        //};

        //void WriteInLog()
        //{
        //    Console.WriteLine("i've been clicked! (from method)");

        //}
        private List<Movie> movies;
        private Dictionary<string, object> dummytextbox = new Dictionary<string, object>() {
                                     { "placeholder", "new movie name"},
                                     { "disabled", "true"},

                                 };
        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(3000);

            //movies = new List<Movie>(){
            //    new Movie(){  Title = "Lucifer",ReleaseDate = new DateTime(2019, 8, 5)},
            //    new Movie() { Title = "Varane Avashyamund", ReleaseDate = new DateTime(2020, 6, 10) },
            //    new Movie(){  Title = "Trance",ReleaseDate = new DateTime(2020, 10, 15)}
            //    };
            movies = repository.GetMovies();

        }
        private void AddNewMovie()
        {

            movies.Add(new Movie() { Title = "new1", ReleaseDate = DateTime.Today });
        }
    }
}

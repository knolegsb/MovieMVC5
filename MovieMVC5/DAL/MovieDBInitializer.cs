using MovieMVC5.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieMVC5.Models
{
    public class MovieDBInitializer : DropCreateDatabaseIfModelChanges<MovieDBContext>
    {
        protected override void Seed(MovieDBContext context)
        {
            var movies = new List<Movie>
            {
                new Movie {Title="When Harry Met Sally", ReleaseDate=DateTime.Parse("1982-03-13"), Genre="Comedy", Price=9.99M, ID=1, Rating="3" },
                new Movie {Title="Ghost Busters", ReleaseDate=DateTime.Parse("1999-09-09"), Genre="Comedy", Price=8.99M, ID=2, Rating="5" }
            };

            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
        }
    }
}
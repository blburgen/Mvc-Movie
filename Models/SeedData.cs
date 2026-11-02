using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M
                },
                new Movie
                {
                    Title = "Dracula Dead and Loving it",
                    ReleaseDate = DateTime.Parse("1995-12-22"),
                    Genre = "Comedy",
                    Price = 9.50M
                },
                new Movie
                {
                    Title = "The Cheap Detective",
                    ReleaseDate = DateTime.Parse("1978-6-23"),
                    Genre = "Comedy",
                    Price = 14.99M
                },
                new Movie
                {
                    Title = "Pirates of the Caribbean",
                    ReleaseDate = DateTime.Parse("2003-7-9"),
                    Genre = "Adventure",
                    Price = 5.53M
                },
                new Movie
                {
                    Title = "Knives Out",
                    ReleaseDate = DateTime.Parse("2019-11-27"),
                    Genre = "Mystery",
                    Price = 15.99M
                },
                new Movie
                {
                    Title = "Star Wars: Episode IV – A New Hope",
                    ReleaseDate = DateTime.Parse("1977-5-25"),
                    Genre = "Sci-fi",
                    Price = 9.993M
                },
                new Movie
                {
                    Title = "How to Train Your Dragon",
                    ReleaseDate = DateTime.Parse("2010-3-21"),
                    Genre = "Adventure",
                    Price = 5.53M
                },
                new Movie
                {
                    Title = "Zootopia",
                    ReleaseDate = DateTime.Parse("2016-3-4"),
                    Genre = "Comedy",
                    Price = 13.99M
                }
            );
            context.SaveChanges();
        }
    }
}
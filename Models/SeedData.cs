using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebDemo.Data;
using System;
using System.Linq;

namespace WebDemo.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new WebDemoContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<WebDemoContext>>()))
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
                        LanguageCode = DateTime.Parse("1989-2-12"),
                        Notes = "Romantic Comedy",
                        
                    },

                    new Movie
                    {
                        Title = "Ghostbusters ",
                        LanguageCode = DateTime.Parse("1984-3-13"),
                        Notes = "Comedy",
                        
                    },

                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Notes = "Comedy",
                        
                    },

                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Notes = "Western",
                       
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

if (context.Movie.Any())
{
    return;  // DB has been seeded.
}
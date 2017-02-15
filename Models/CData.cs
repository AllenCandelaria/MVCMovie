using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCMovie.Data;
namespace MVCMovie.Models
{
    public class CData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context =
                    new ApplicationDbContext(
                        serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                //look for any records, if there are records do nothig
                if (context.Movie.Any())
                {
                    return;
                }
                context.Movie.AddRange(
                    new Movie
                    {
                        title = "when Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1984-03-13"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M

                    },
                    new Movie

                    {
                        title = "Goastbusters 2",
                        ReleaseDate = DateTime.Parse("1999-01-01"),
                        Genre = "comedy",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        title = "kill Bill",
                        ReleaseDate = DateTime.Parse("2004-02-22"),
                        Genre = "action",
                        Price = 13.22M

                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
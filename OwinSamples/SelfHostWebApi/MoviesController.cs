using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfHostWebApi
{
    public class MoviesController : ApiController
    {
        public IQueryable<Movie> Get()
        {
            return GetMovies();
        }

        public Movie Get(int id)
        {
            return GetMovies().Where(x => x.ID == id).SingleOrDefault();
        }

        private static IQueryable<Movie> GetMovies()
        {
                    return new List<Movie>()
                    {
                        new Movie() { ID = 1, Title = "12 Years a Slave", IsOscarNominated=true, Director = "Steve McQueen", ReleaseYear = 2013 },
                        new Movie() { ID = 2, Title = "American Hustle", IsOscarNominated=true, Director = "David O. Russell", ReleaseYear = 2013 },
                        new Movie() { ID = 3, Title = "Wolf of Wall Street", IsOscarNominated=true, Director = "Martin Scorsese", ReleaseYear = 2013 },
                        new Movie() { ID = 4, Title = "Gravity", IsOscarNominated=true, Director = "Alfonso Cuarón", ReleaseYear = 2013 },
                    }.AsQueryable();
        }
    }

    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public bool IsOscarNominated { get; set; }
    }
}

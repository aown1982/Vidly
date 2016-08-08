using System.Collections.Generic;
using System.Web.Mvc;
using VidlyWeb.Models;
using VidlyWeb.ViewModel;

namespace VidlyWeb.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};
            var customers = new List<Customer>()
            {
                new Customer(){Name="Customer 1"},
                new Customer(){Name="Customer 2"}
            };
            var viewModel = new RandomViewModel()
            {
                Movie = movie,
                Customers = customers

            };

            return View(viewModel);

        }



        public ViewResult Index()
        {
            var movies = GetMovies();

            return View(movies);    
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1, Name = "Shrek" },
                new Movie { Id = 2, Name = "Wall-e" }
            };
        }


        //public ActionResult Edit(int id)
        //{
        //    return Content(string.Format("id={0}", id));
        //}

        //public ActionResult ByReleaseDate(int year,int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //[Route("movies/released/{year}/{month:regex(\\d{2}):range(1:12)}")]
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{

        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrEmpty(sortBy))
        //        sortBy = "Name";

        //    return Content(string.Format("pageIndex={0}&sortyBy={1}", pageIndex, sortBy));
        //}


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidley.Models;

namespace Vidley.ViewModels
{
    public class RandomMovieViewModel
    {
        public MovieModels Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
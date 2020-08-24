﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieCustomerMvcAppWithAuth.Models.ViewModel
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> GenreType { get; set; }
        public Movie Movie { get; set; }
    }
}
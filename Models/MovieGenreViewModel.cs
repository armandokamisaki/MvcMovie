﻿using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
    public List<Movie>? Movies { get; set; }
    public SelectList? Genres { get; set; }
    public int? MovieGenre { get; set; }
    public string? SearchString { get; set; }
    public SelectList? DatesList { get; set; }
    public DateTime MyDate { get; set; }
}

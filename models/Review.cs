using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;


namespace RazorPagesMovie.Models
{
    public class Review
    {
        public int ReviewID {get; set;}
        public Movie Movie {get; set;}

        public int ID {get; set;}

        [Range(1, 5)]
        public int Score {get; set;}
    }
}
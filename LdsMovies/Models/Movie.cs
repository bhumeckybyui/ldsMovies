﻿using System;
using System.ComponentModel.DataAnnotations;

namespace LdsMovies.Models
{
    
        public class Movie
        {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }


        [Required]
        [StringLength(30)]
        public string Genre { get; set; }


       
        [StringLength(5)]
        [Required]
        public string Rating { get; set; }

        }

}

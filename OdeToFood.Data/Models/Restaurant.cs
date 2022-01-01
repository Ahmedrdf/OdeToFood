﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Models
{
  public  class Restaurant
    {
        // [Range(1,10] == betwenn 1 and 10
        // [DataType(DataType.Password)]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}

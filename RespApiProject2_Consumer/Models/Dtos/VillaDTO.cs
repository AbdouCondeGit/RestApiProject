﻿using System.ComponentModel.DataAnnotations;

namespace RespApiProject2_Consumer.Models.Dtos
{
    public class VillaDTO
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        public string Details { get; set; }
        [Required]
        public double Rate { get; set; }
        public int Occupancy { get; set; }
        public int Sqft { get; set; }
        public string ImageUrl { get; set; }
        public string Amenity { get; set; }

        

    }
}

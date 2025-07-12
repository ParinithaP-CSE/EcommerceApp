using EcommerceApp.Data;
using System;

namespace EcommerceApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public double Price {  get; set; }
        public string ImageURL {  get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public MovieCategory MoviCategory { get; set; }
    }
}

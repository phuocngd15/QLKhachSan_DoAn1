using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_Demo.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(dataType:DataType.Date)] public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }

    }
}
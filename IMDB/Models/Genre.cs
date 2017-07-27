using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IMDB.Models
{
    public class Genre
    {
        [Key]
        public int GenreID;
        public string GenreName;

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
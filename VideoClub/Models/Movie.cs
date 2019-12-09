using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Movie
    {
        public int MovieID { get; set; }

        public string Title { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Lenght { get; set; }

        public string MovieLanguage { get; set; }

        public string ContryOfProduction { get; set; }     // Dropdown when the movie is being added

        public string Genre { get; set; }

        // Navigation

        public virtual ICollection <MovieCast> MovieCasts { get; set; }





    }
}

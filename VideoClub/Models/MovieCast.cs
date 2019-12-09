using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class MovieCast
    {
        public int MovieCastID { get; set; }

        public string MovieRole { get; set; }

        //

        public Person Person { get; set; }

        public Movie Movie { get; set; }
    }
}

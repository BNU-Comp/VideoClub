using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Award
    {
        int AwardID { get; set; }

        string AwardName { get; set; }

        int AwardYear { get; set; }

        //

        public virtual Movie Movie { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Address
    {

        [ForeignKey("Person")]
        public int AddressId { get; set; }

        public string PostCode { get; set; }

        public string Steet { get; set; }

        public string County { get; set; }

        public string Contry { get; set; }




    }
}

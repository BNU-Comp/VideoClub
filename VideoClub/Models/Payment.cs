using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoClub.Models
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public int CardNumber { get; set; }

        public string CardType{ get; set; }

        public string CardName { get; set; }

        public int Cvv { get; set; }

        public int ExperingMonth { get; set; }

        public int ExperingDay { get; set; }





    }
}

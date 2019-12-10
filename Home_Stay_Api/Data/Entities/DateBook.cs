using Home_Stay_Api.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class DateBook : DomainEntity<int>
    {
        public int IdProduct { get; set; }
        public DateTime Date { get; set; }

    }
}

using Home_Stay_Api.Data.Interface;
using Home_Stay_Api.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class UserContact : DomainEntity<int> ,IDateTracking
    {


        public Guid IdAppUser { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string  Telephone { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}

using Home_Stay_Api.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class Permisson : DomainEntity<int>

    {
        public Guid RoleId { get; set; }

        public int FunctionId { get; set; }
        public bool CanCreate { set; get; }
        public bool CanCRead { set; get; }
        public bool CanUpdate { set; get; }
        public bool CanDelete { set; get; }
    }
}

using Home_Stay_Api.Data.Enums;
using Home_Stay_Api.Data.Interface;
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class Bill : DomainEntity<int>, IDateTracking,IHasOwner<Guid>
    {
        public int IdRoom { get; set; }
      

        public BookStatus Bookstatus { get; set; }

        public CardPayment CardPayment { get;set; }
        
        public DateTime DateCreated { get;set;}
        public DateTime DateModified { get;set;}
        public Guid OwnerId { get; set; }
    }
}

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
    public class Room : DomainEntity<int>, IDateTracking, ISwitchable, IShowPages

    {
        public string Name { get; set; }

        public int IDHouse { get; set; }

        public bool IsSale { get; set; }

        public decimal Sale { get; set; }

        public decimal Price { get; set; }

        public bool IsPet { get; set; }

        public int PersonMax { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public bool isHome { get; set; }
        public bool isBlog { get; set; }
        public bool isTour { get; set; }
        public Status Status { get; set; }
        public bool isAbout { get; set; }
    }
}

using Home_Stay_Api.Data.Enums;
using Home_Stay_Api.Data.Interface;
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;
using System;

namespace Home_Stay_Api.Data.Entities
{
    public class House : DomainEntity<int>, IDateTracking, IHasOwner<Guid>, ISwitchable, IShowPages

    {
        public string Name { get; set; }
        public string Adrress { get; set; }


        public decimal PointX { get; set; }
        public decimal PointY { get; set; }

        public string Description { get; set; }
        public int Id_TypeHome { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public Guid OwnerId { get; set; }
        public Status Status { get; set; }
        public bool isHome { get; set; }
        public bool isBlog { get; set; }
        public bool isTour { get; set; }
        public bool isAbout { get; set; }
    }
}

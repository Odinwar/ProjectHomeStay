
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;
using System;

namespace Home_Stay_Api.Data.Entities
{
    public class Cart : DomainEntity<int>

    {
        public Guid IdUser { get; set; }

    }
}

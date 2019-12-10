using System;
using Home_Stay_Api.Data.Interface;
using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class ImageRoom : DomainEntity<int>, IDateTracking

    {

        public string URL { get; set; }

        public string IdRoom { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }



    }
}

using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class Comment_Slide : DomainEntity<int>, IShowPages

    {
        public string IdUserContacts { get; set; }
        public string Content { get; set; }
        public bool isHome { get; set; }
        public bool isBlog { get; set; }
        public bool isTour { get; set; }
        public bool isAbout { get; set; }
    }
}

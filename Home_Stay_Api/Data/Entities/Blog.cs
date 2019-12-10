
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class Blog : DomainEntity<int>, IShowPages

    {
        public string Title { get; set; }
        public string Image { get; set; }

        public string Content { get; set; }
        public bool isHome { get; set; }
        public bool isBlog { get; set; }
        public bool isTour { get; set; }
        public bool isAbout { get; set; }
    }
}

using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class Slide : DomainEntity<int>

    {
        public string Name { get; set; }
        public string UrlImage1 { get; set; }
        public string UrlImage2 { get; set; }
        public string Title2 { get; set; }
        public string Title1 { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }

    }
}

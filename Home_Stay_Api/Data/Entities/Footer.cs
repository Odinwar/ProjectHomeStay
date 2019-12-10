
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class Footer : DomainEntity<int>

    {
        public string Name { get; set; }
        public string URL { get; set; }
    }
}

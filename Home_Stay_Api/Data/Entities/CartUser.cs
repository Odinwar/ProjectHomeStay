
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;

namespace Home_Stay_Api.Data.Entities
{
    public class CartUser : DomainEntity<int>
    {
        public int IdCart { get; set; }
        public int IdRoom { get; set; }

    }
}

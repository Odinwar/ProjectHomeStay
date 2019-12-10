namespace Home_Stay_Api.Data.Interfaces
{
    public interface IShowPages
    {
        bool isHome { get; set; }
        bool isBlog { get; set; }
        bool isTour { get; set; }

        bool isAbout { get; set; }
    }
}

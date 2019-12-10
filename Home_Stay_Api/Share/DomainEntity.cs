namespace Home_Stay_Api.Share
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }
        public bool IsTransinent()
        {
            return Id.Equals(default(T));
        }
    }
}

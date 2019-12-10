using System;

namespace Home_Stay_Api.Data.Interface
{
    public interface IDateTracking
    {
        DateTime DateCreated { get; set; }
        DateTime DateModified { get; set; }
    }
}

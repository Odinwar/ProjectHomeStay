using Home_Stay_Api.Data.Enums;
using Home_Stay_Api.Data.Interface;
using Home_Stay_Api.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {

        
        public DateTime DateCreated {get;set;}
        public DateTime DateModified {get;set;}
        public Status Status {get;set;}
    }
}

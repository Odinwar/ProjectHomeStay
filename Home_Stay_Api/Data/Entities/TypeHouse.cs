using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Home_Stay_Api.Share;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Home_Stay_Api.Data.Entities
{
    public class TypeHouse : DomainEntity<int>

    {
        public string Name { get; set; }
        public string UrlImage { get; set; }

    }
}

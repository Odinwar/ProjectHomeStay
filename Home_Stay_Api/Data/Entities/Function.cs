using Home_Stay_Api.Data.Enums;
using Home_Stay_Api.Data.Interfaces;
using Home_Stay_Api.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class Function : DomainEntity<int>, ISwitchable
    {
        public Function()
        {

        }
        public Function(string name , string url,string parentID,string iConCss)
        {
            this.Name = name;
            this.ParentID = parentID;
            this.IconCss = iConCss;
            this.Status = Status.Active;
        }
        public string Name { get; set; }
        public string URL { get; set; }
        public string ParentID { get; set; }
        public string IconCss { get; set; }
      
        public Status Status { get; set; }
    }
}

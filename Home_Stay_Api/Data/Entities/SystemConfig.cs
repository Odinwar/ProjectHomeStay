using Home_Stay_Api.Data.Enums;
using Home_Stay_Api.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Home_Stay_Api.Data.Entities
{
    public class SystemConfig : ISwitchable
    {
        public string name { get; set; }

        public string Value1 { get; set; }

        public int? Value2 { get; set; }

        public bool? Value3 { get; set; }
        public DateTime? Value4 { get; set; }
        public decimal Value5 { get; set; }

        public Status Status { get; set; }
     
    }
}

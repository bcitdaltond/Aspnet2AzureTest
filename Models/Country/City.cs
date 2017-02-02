using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab3.Models.Country
{
    //Type Display Comment
    //CityId  Integer Key
    //CityName String  City Example: Surrey
    //Population  Integer Example: 300,000
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int Population { get; set; }
        public string ProvinceCode { get; set; }
        public Province Province { get; set; }
    }
}
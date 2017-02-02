using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models.Country
{

    //Type Display Comment
    //ProvinceCode    String Province Code Key, Example: BC
    //ProvinceName    String Province    Example: British Columbia
    //Cities Collection      Example: Surrey, Richmond, Coquitlam, ...

    public class Province
    {
        [Key]
        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public List<City> Cities { get; set; }
    }
}
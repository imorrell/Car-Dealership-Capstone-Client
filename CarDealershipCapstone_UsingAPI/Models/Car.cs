using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDealershipCapstone_UsingAPI.Models
{


    public class Carobject
    {
        public Cars[] Property1 { get; set; }
    }

    public class Cars
    {
        public int id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string year { get; set; }
        public string color { get; set; }
        public object userId { get; set; }
        public object user { get; set; }
    }


}

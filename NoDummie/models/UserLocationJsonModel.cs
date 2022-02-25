using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{   
    public class Location
    {
        public List<UserLocationJsonModel> location { get; set; }
    }
    public class UserLocationJsonModel
    {
        public string Id { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
        public string city { get; set; }
    }
}

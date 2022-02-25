using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class Address
    {
        public List<UserBillingAddressJsonModel> address { get; set; }
    }
    public class UserBillingAddressJsonModel
    {
        public string id { get; set; }
        public string streetname { get; set; }
        public string housenumber { get; set; }
        public string postalcode  { get; set; }
        public string city { get; set; }
    }
}

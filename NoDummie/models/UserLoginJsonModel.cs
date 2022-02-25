using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class UserLogins
    {
        public List<UserLoginJsonModel> userlogins { get; set; }
    }

    public class UserLoginJsonModel : UserLogins
    {
        public string id { get; set; }
        public string email { get; set; }
        public string time { get; set; }
        public string date { get; set; }
        public string login { get; set; }

    }
}

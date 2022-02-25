using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class Rows
    {
        public List<UserJsonModel> rows { get; set; }
    }

    public class UserJsonModel : Rows
    {
        public string Id { get; set; }
        public string alias { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string date { get; set; }
        public string premium { get; set; }

    }
}

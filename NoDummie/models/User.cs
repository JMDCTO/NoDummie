using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class User
    {
        public string Id { get; set; }
        public string alias { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string date { get; set; }
        public string premium { get; set; }

        public User(string id, string alias, string email, string password, string date, string premium)
        {
            this.Id = id;
            this.alias = alias;
            this.email = email; 
            this.password = password;
            this.date = date;
            this.premium = premium;

        }
    }
}

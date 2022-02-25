using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class Partners
    {
        public List<Partner> partners { get; set; }

        public class Partner
        {
            public string Id { get; set; }
            public string official_name { get; set; }
            public string alias { get; set; }
            public string street { get; set; }
            public string house_number { get; set; }
            public string postal { get; set; }
            public string city { get; set; }
            public string latitude { get; set; }
            public string longitude { get; set; }
        }
    }
}

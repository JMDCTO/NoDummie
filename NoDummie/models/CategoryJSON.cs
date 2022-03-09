using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoDummie.models
{
    public class CategoryJSON
    {
        public List<Category> categories { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string logo { get; set; }

    }
}

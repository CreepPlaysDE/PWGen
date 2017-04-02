using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PWGen.API;

namespace PWGen.API
{
    public class Category
    {
        public string Name { get; set; }

        public List<Login> Logins { get; set; }
    }
}

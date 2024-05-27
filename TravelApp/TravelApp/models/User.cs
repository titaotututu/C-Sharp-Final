using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.models
{
    internal class User
    {
        public long Uid { get; set; }
        public string Uname { get; set; }
        public long Password { get; set; }

        public User() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp.models
{
    internal class User
    {
        public long UserId { get; set; }
        public string UserName { get; set; }
        public long password { get; set; }

        public User() { }
    }
}

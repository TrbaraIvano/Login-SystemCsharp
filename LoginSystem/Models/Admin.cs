using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Models
{
    public class Admin : User
    {
        public Admin(string username, string password) : base(username, password, "Admin")    {}
    }
}

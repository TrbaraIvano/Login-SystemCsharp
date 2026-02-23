using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginSystem.Models;

namespace LoginSystem.Service
{
    public class AuthService
    {
        private List<User> UserList { get; set; } = new List<User>();
        public string Path { get; } = "users.csv";

    }
}

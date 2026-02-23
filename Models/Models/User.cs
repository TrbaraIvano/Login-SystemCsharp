using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSystem.Models
{
    public abstract class User
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }

        public User(string userName, string passworHash, string role)
        {
            UserName = userName;
            PasswordHash = passworHash;
            Role = role;
        }

        public string GetInfo()
        {
            return $"{UserName} mit der Rolle {Role}";
        }

        public bool CheckPassword(string inputHash)
        {
            return PasswordHash == inputHash;
        }
    }
}

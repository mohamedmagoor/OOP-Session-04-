using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass04.Interfaces
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
         public string UserName { get; set; }
         public string Password { get; set; }

        public string Role { get; set; }
        public bool AuthenticateUser(string username, string password)
        {
            if( UserName == username && Password == password)
            {
                return true;
            }
            else {  return false; }
            
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (UserName == username && Role == role)
            {
                return true;
            }
            else { return false; }
        }
    }
}

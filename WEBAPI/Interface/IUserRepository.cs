using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Model;

namespace WEBAPI.Interface
{
    public interface IUserRepository
    {
      
            Task<User> Authenticate(string username , string password);
       
    }
}

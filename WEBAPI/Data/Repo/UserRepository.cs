using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPI.Interface;
using WEBAPI.Model;

namespace WEBAPI.Data.Repo
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext dc;
        public UserRepository(DataContext dc)
        {
            this.dc = dc;       
        }
        public async Task<User> Authenticate(string username, string password)
        {
          return await   dc.Users.FirstOrDefaultAsync(a=>a.UserName==username && a.Password==password);
        }
    }
}

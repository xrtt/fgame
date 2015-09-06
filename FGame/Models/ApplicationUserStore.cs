using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

using Microsoft.AspNet.Identity;

namespace FGame.Models
{
    public class ApplicationUserStore : IUserStore<ApplicationUser>, IUserPasswordStore<ApplicationUser>
    {
        private static List<ApplicationUser> _users = new List<ApplicationUser>();

        public Task CreateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        public Task DeleteAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            //throw new NotImplementedException();
        }
        public Task<ApplicationUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }
        public Task<ApplicationUser> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        public Task<bool> HasPasswordAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        public Task SetPasswordHashAsync(ApplicationUser user, string passwordHash)
        {
            throw new NotImplementedException();
        }
        public Task UpdateAsync(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public static ApplicationUserStore Create()
        {
            return new ApplicationUserStore();
        }
    }
}
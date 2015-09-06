using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace FGame.Models
{
    public class ApplicationUser : IUser<string>
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int Role { get; set; }
        public string PasswordHash { get; set; }
        public bool Fee { get; set; }
    }
}
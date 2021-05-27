using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IBBS.Models
{
    public class Users : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Likes> Likes { get; set; }
        public List<SavedHamburgers> Burgers { get; set; }
        public List<Comments> Comments { get; set; }
    }
}

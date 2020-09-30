using Microsoft.AspNetCore.Identity;
using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<Comment> Comments { get; set; }

        public List<NewsSave> NewsSaves { get; set; }

        public List<New> News { get; set; }
    }
}
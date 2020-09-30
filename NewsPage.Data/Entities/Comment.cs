using NewsPage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsPage.Data.Entities
{
    public class Comment
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Content { get; set; }

        public int NewsId { get; set; }

        public DateTime DateCreated { get; set; }
        public Guid UserId { get; set; }

        public New New { get; set; }

        public AppUser AppUser { get; set; }
    }
}